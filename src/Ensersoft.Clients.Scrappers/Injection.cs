using System.Net;
using System.Net.Sockets;
using Ensersoft.Clients.Common;
using Ensersoft.Clients.Common.Extensions;
using Ensersoft.Clients.Common.Utilities.Http;
using Ensersoft.Clients.Scrappers.Abstractions;
using Ensersoft.Clients.Scrappers.FactData;
using Ensersoft.Clients.Scrappers.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.Extensions.Http;
using Polly.Timeout;

namespace Ensersoft.Clients.Scrappers;

public static class Injection
{
    private static readonly IReadOnlyCollection<Func<HttpRequestMessage, bool>> DefaultAllowRetryFilters =
        new List<Func<HttpRequestMessage, bool>>()
        {
            r => r.Method == HttpMethod.Get
        };

    public static IServiceCollection AddScrappersClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAndValidateOptions<ScrappersClientOptions>(configuration, "ScrappersService");
        services.AddScoped<IFactHoursClient, FactHoursClient>();
        services.AddScoped<IFactPriceClient, FactPriceClient>();
        services.AddHttpClient(InternalApiClients.ScrappersClient)
            .ConfigureHttpClient((sp, c) =>
            {
                var options = sp.GetRequiredService<ScrappersClientOptions>();
                c.DefaultRequestHeaders.TryAddWithoutValidation("ApiKey", options.ApiKey);
                c.BaseAddress = new Uri(options.Url);
            })
            .AddPolicyHandler((sp, request) => AddRetryPolicy(sp, request, DefaultAllowRetryFilters))
            .ConfigurePrimaryHttpMessageHandler(_ => new DefaultHttpClientHandler());
        return services;
    }

    public static IAsyncPolicy<HttpResponseMessage> AddRetryPolicy(IServiceProvider serviceProvider,
        HttpRequestMessage request, IReadOnlyCollection<Func<HttpRequestMessage, bool>>? allowRetryFilters = null)
    {
        if (allowRetryFilters?.Any(f => f(request)) == true)
        {
            var retryPolicy = HttpPolicyExtensions
                .HandleTransientHttpError() // HttpRequestException, 5XX and 408
                .Or<SocketException>()
                .OrInner<SocketException>()
                .Or<TimeoutRejectedException>()
                .OrResult(response => response.StatusCode == HttpStatusCode.TooManyRequests)
                .WaitAndRetryAsync(
                    3,
                    sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt - 1)),
                    onRetryAsync: (outcome, timespan, retryAttempt, _context) =>
                        LogRetry(serviceProvider, outcome, retryAttempt, timespan));

            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60));
            return retryPolicy.WrapAsync(timeoutPolicy);
        }

        return Policy.NoOpAsync().AsAsyncPolicy<HttpResponseMessage>();
    }

    private static async Task LogRetry(
        IServiceProvider serviceProvider,
        DelegateResult<HttpResponseMessage> outcome,
        int retryAttempt,
        TimeSpan timespan)
    {
        string? response = null;

        try
        {
            var content = outcome?.Result?.Content;
            if (content != null)
            {
                response = await content.ReadAsStringAsync();
            }
        }
        catch { }

        var logger = serviceProvider.GetRequiredService<ILogger<HttpClient>>();
        logger.LogWarning(outcome?.Exception,
            "Delaying for {Delay}ms," +
            " then making retry {Retry}. Status code: {StatusCode}. Response: {Response}",
            timespan.TotalMilliseconds, retryAttempt, outcome?.Result?.StatusCode, response);

        outcome?.Result?.Dispose();
    }
}