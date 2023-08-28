namespace Ensersoft.Clients.Predictor.Abstractions.Models.Inner;

public record InnerPredictRequest
{
    public string Region { get; set; } = default!;
    public int FromYear { get; set; }
    public int FromMonth { get; set; }
    public int ToYear { get; set; }
    public int ToMonth { get; set; }

    public InnerPredictRequest(string region, int fromYear, int fromMonth, int toYear, int toMonth)
    {
        Region = region;
        FromYear = fromYear;
        FromMonth = fromMonth;
        ToYear = toYear;
        ToMonth = toMonth;
    }

    public static InnerPredictRequest FromPredictRequest(PredictRequest predictRequest)
    {
        return new InnerPredictRequest(predictRequest.Region,
         predictRequest.FromDate.Year, predictRequest.FromDate.Month, predictRequest.ToDate.Year, predictRequest.ToDate.Month);
    }
}
