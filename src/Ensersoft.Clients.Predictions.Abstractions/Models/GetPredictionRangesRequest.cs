namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record GetPredictionRangesRequest
{
    public ICollection<int>? RegionKeys { get; init; } = default!;

    public GetPredictionRangesRequest(ICollection<int>? regionKeys)
    {
        RegionKeys = regionKeys;
    }
}