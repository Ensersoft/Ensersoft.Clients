using Ensersoft.Clients.WebApi.Abstractions.Models;

namespace Ensersoft.Clients.WebApi.Abstractions;

public interface IPredictorRegionsClient
{
    Task<GetPredictorRegionsResponse> GetPredictorRegions(GetPredictorRegionsRequest request,
        CancellationToken cancellationToken = default);
}
