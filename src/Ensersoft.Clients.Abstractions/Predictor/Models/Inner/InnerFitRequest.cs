namespace Ensersoft.Clients.Abstractions.Predictor.Models.Inner;

public record InnerFitRequest
{
    public string Region { get; set; } = default!;
    public int ToYear { get; set; }
    public int ToMonth { get; set; }

    public InnerFitRequest(string region, int toYear, int toMonth)
    {
        Region = region;
        ToYear = toYear;
        ToMonth = toMonth;
    }

    public static InnerFitRequest FromFitModelRequest(FitModelRequest fitRequest)
    {
        return new InnerFitRequest(fitRequest.Region, fitRequest.ToDate.Year, fitRequest.ToDate.Month);
    }
}
