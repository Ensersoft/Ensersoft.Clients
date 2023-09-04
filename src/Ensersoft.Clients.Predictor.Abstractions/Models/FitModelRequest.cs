using Ensersoft.Clients.Common.DateMonth;

namespace Ensersoft.Clients.Predictor.Abstractions.Models;

public record FitModelRequest
{
    public int RegionKey { get; set; }
    public DateMonthOnly ToDate { get; set; } = default!;
    public FitModelRequest(int regionKey, DateMonthOnly toDate)
    {
        RegionKey = regionKey;
        ToDate = toDate;
    }
}
