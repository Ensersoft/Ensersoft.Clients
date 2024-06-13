using Ensersoft.Clients.WebApi.Abstractions.Models.Common;

namespace Ensersoft.Clients.WebApi.Abstractions.Models;

public record GetPredictorRegionsResponse
{
    public ICollection<PredictorRegionData> Data { get; init; } = default!;
}
