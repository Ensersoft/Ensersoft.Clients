using Ensersoft.Clients.Common.DateMonth;

namespace Ensersoft.Clients.Predictor.Abstractions.Models;

public record PredictRequest : BaseRegionRangeRequest
{
    public PredictRequest(string region, DateMonthOnly fromDate, DateMonthOnly toDate) : base(region, fromDate, toDate)
    {
    }
}
