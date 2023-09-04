using Ensersoft.Clients.Common.DateMonth;

namespace Ensersoft.Clients.Predictor.Abstractions;

public abstract record BaseRegionRangeRequest
{
    public int RegionKey { get; set; }
    public DateMonthOnly FromDate { get; set; } = default!;
    public DateMonthOnly ToDate { get; set; } = default!;

    protected BaseRegionRangeRequest(int regionKey, DateMonthOnly fromDate, DateMonthOnly toDate)
    {
        RegionKey = regionKey;
        FromDate = fromDate;
        ToDate = toDate;
    }
}