namespace Ensersoft.Clients.Predictor.Abstractions.Models.Inner;

public record InnerPredictRequest
{
    public int RegionKey { get; set; }
    public int FromYear { get; set; }
    public int FromMonth { get; set; }
    public int ToYear { get; set; }
    public int ToMonth { get; set; }

    public InnerPredictRequest(int regionKey, int fromYear, int fromMonth, int toYear, int toMonth)
    {
        RegionKey = regionKey;
        FromYear = fromYear;
        FromMonth = fromMonth;
        ToYear = toYear;
        ToMonth = toMonth;
    }

    public static InnerPredictRequest FromPredictRequest(PredictRequest predictRequest)
    {
        return new InnerPredictRequest(predictRequest.RegionKey,
         predictRequest.FromDate.Year, predictRequest.FromDate.Month, predictRequest.ToDate.Year, predictRequest.ToDate.Month);
    }
}
