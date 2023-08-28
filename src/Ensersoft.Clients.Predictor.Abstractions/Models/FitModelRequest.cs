using Ensersoft.Clients.Common.DateMonth;

namespace Ensersoft.Clients.Predictor.Abstractions.Models;

public record FitModelRequest
{
    public string Region { get; set; } = default!;
    public DateMonthOnly ToDate { get; set; } = default!;
    public FitModelRequest(string region, DateMonthOnly toDate)
    {
        Region = region;
        ToDate = toDate;
    }
}
