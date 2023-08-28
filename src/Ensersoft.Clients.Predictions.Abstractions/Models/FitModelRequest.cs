namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record FitModelRequest
{
    public string Region { get; set; } = default!;
    public int ToYear { get; set; }
    public int ToMonth { get; set; }
    public FitModelRequest(string region, int toYear, int toMonth)
    {
        Region = region;
        ToYear = toYear;
        ToMonth = toMonth;
    }
}
