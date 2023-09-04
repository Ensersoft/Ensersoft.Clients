namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record PredictRequest : BaseRegionRangeRequest
{
    public PredictRequest(int regionKey, int fromYear, int fromMonth, int toYear, int toMonth)
    {
        RegionKey = regionKey;
        FromYear = fromYear;
        FromMonth = fromMonth;
        ToYear = toYear;
        ToMonth = toMonth;
    }
}
