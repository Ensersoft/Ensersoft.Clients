namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record PredictRequest : BaseRegionRangeRequest
{
    public PredictRequest(string region, int fromYear, int fromMonth, int toYear, int toMonth)
    {
        Region = region;
        FromYear = fromYear;
        FromMonth = fromMonth;
        ToYear = toYear;
        ToMonth = toMonth;
    }
}
