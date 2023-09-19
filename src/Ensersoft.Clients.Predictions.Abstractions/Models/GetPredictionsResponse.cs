using Ensersoft.Clients.Predictions.Abstractions.Models.Common;

namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record GetPredictionsResponse
{
    public ICollection<PredictionData> Items { get; init; } = default!;
}
