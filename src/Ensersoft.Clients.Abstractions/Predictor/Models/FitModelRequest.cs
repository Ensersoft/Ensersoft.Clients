using Ensersoft.Clients.Abstractions.DateMonth;

namespace Ensersoft.Clients.Abstractions.Predictor.Models;

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
