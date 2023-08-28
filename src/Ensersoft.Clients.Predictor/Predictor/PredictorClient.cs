using System.Net.Http.Json;
using Ensersoft.Clients.Predictor.Abstractions;
using Ensersoft.Clients.Predictor.Abstractions.Common;
using Ensersoft.Clients.Predictor.Abstractions.Models;
using Ensersoft.Clients.Predictor.Abstractions.Models.Inner;

namespace Ensersoft.Clients.Predictor.Predictor;

public class PredictorClient : PredictorClientBase, IPredictorClient
{
    protected override string BaseAddress => $"{base.BaseAddress}model/";

    public PredictorClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task SetupModel(SetupModelRequest request,
        CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}", UriKind.Relative);
        using var _ = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, InnerSetupRequest.FromSetupModelRequest(request), cancellationToken));
    }

    public async Task FitModel(FitModelRequest request,
        CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}fit", UriKind.Relative);
        using var _ = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, InnerFitRequest.FromFitModelRequest(request), cancellationToken));
    }

    public async Task<PredictionResult> Predict(PredictRequest request,
        CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}predict", UriKind.Relative);
        using var response = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, InnerPredictRequest.FromPredictRequest(request), cancellationToken));
        var predictionResult = await response.Content.ReadFromJsonAsync<PredictionResult>(cancellationToken: CancellationToken.None);
        return predictionResult!;
    }
}
