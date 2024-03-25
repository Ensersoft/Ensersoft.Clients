using System.Net.Http.Json;
using Ensersoft.Clients.Predictions.Abstractions.Models;
using Ensersoft.Clients.Predictions.Abstractions;

namespace Ensersoft.Clients.Predictions.Predictions;

public class PredictionsClient : PredictionsClientBase, IPredictionsClient
{
    protected override string BaseAddress => $"{base.BaseAddress}Predictions/";

    public PredictionsClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task<GetPredictionsResponse> GetPredictions(GetPredictionsRequest request,
        CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}query", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetPredictionsResponse>(cancellationToken: cancellationToken);
        return result!;
    }

    public async Task<GetPredictionRangesResponse> GetPredictionRanges(GetPredictionRangesRequest request, CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}ranges", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetPredictionRangesResponse>(cancellationToken: cancellationToken);
        return result!;
    }
}
