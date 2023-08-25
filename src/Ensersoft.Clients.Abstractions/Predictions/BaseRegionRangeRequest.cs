namespace Ensersoft.Clients.Abstractions.Predictions;

public abstract record BaseRegionRangeRequest
{
    public string Region { get; set; } = default!;
    public int FromYear { get; set; }
    public int FromMonth { get; set; }
    public int ToYear { get; set; }
    public int ToMonth { get; set; }
}