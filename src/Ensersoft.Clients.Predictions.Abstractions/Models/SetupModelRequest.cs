namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record SetupModelRequest : BaseRegionRangeRequest
{
    public SetupModelRequest(int regionKey, int fromYear, int fromMonth, int toYear, int toMonth)
    {
        RegionKey = regionKey;
        FromYear = fromYear;
        FromMonth = fromMonth;
        ToYear = toYear;
        ToMonth = toMonth;
    }
}
