using Ensersoft.Clients.Predictions.Abstractions.Models.Common;

namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record GetPredictionRangesResponse
{
    public ICollection<PredictionRange> Items { get; init; } = default!;
}
