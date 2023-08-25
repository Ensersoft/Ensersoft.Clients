using Ensersoft.Clients.Abstractions.DateMonth;

namespace Ensersoft.Clients.Abstractions.Predictor.Models;

public record PredictRequest : BaseRegionRangeRequest
{
    public PredictRequest(string region, DateMonthOnly fromDate, DateMonthOnly toDate) : base(region, fromDate, toDate)
    {
    }
}
