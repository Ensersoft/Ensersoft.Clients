namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record FitModelRequest
{
    public int RegionKey { get; set; } = default!;
    public int ToYear { get; set; }
    public int ToMonth { get; set; }
    public FitModelRequest(int regionKey, int toYear, int toMonth)
    {
        RegionKey = regionKey;
        ToYear = toYear;
        ToMonth = toMonth;
    }
}
