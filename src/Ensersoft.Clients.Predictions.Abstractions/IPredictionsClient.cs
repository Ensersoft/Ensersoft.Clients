using Ensersoft.Clients.Predictions.Abstractions.Models;

namespace Ensersoft.Clients.Predictions.Abstractions;

public interface IPredictionsClient
{
    Task<GetPredictionsResponse> GetPredictions(GetPredictionsRequest request,
        CancellationToken cancellationToken = default);
}
