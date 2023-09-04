using Ensersoft.Clients.Common.DateMonth;

namespace Ensersoft.Clients.Predictor.Abstractions.Models;

public record PredictRequest : BaseRegionRangeRequest
{
    public PredictRequest(int regionKey, DateMonthOnly fromDate, DateMonthOnly toDate) : base(regionKey, fromDate, toDate)
    {
    }
}
