namespace Ensersoft.Clients.Scrappers.Abstractions.Models;

public record GetFactHoursRangesRequest
{
    public ICollection<int>? RegionKeys { get; init; } = default!;

    public GetFactHoursRangesRequest(ICollection<int>? regionKeys)
    {
        RegionKeys = regionKeys;
    }
}