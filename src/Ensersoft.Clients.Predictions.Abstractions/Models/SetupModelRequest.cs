namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record SetupModelRequest : BaseRegionRangeRequest
{
    public SetupModelRequest(string region, int fromYear, int fromMonth, int toYear, int toMonth)
    {
        Region = region;
        FromYear = fromYear;
        FromMonth = fromMonth;
        ToYear = toYear;
        ToMonth = toMonth;
    }
}
