using System.Net.Http.Json;
using Ensersoft.Clients.Abstractions.Predictions;
using Ensersoft.Clients.Abstractions.Predictions.Models;

namespace Ensersoft.Clients.Predictions.Predictions;

public class PredictionsModelClient : PredictionsClientBase, IPredictionsModelClient
{
    protected override string BaseAddress => $"{base.BaseAddress}Model/";

    public PredictionsModelClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task SetupModel(SetupModelRequest request,
        CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}setup", UriKind.Relative);
        using var _ = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
    }

    public async Task FitModel(FitModelRequest request,
        CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}fit", UriKind.Relative);
        using var _ = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
    }

    public async Task Predict(PredictRequest request,
        CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}predict", UriKind.Relative);
        using var _ = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
    }
}
