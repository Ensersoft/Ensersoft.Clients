using Ensersoft.Clients.Abstractions.DateMonth;

namespace Ensersoft.Clients.Abstractions.Predictor;

public abstract record BaseRegionRangeRequest
{
    public string Region { get; set; } = default!;
    public DateMonthOnly FromDate { get; set; } = default!;
    public DateMonthOnly ToDate { get; set; } = default!;

    protected BaseRegionRangeRequest(string region, DateMonthOnly fromDate, DateMonthOnly toDate)
    {
        Region = region;
        FromDate = fromDate;
        ToDate = toDate;
    }
}