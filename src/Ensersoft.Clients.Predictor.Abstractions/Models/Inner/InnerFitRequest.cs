namespace Ensersoft.Clients.Predictor.Abstractions.Models.Inner;

public record InnerFitRequest
{
    public int RegionKey { get; set; }
    public int ToYear { get; set; }
    public int ToMonth { get; set; }

    public InnerFitRequest(int regionKey, int toYear, int toMonth)
    {
        RegionKey = regionKey;
        ToYear = toYear;
        ToMonth = toMonth;
    }

    public static InnerFitRequest FromFitModelRequest(FitModelRequest fitRequest)
    {
        return new InnerFitRequest(fitRequest.RegionKey, fitRequest.ToDate.Year, fitRequest.ToDate.Month);
    }
}
