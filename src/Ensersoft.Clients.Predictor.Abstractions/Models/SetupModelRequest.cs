using Ensersoft.Clients.Common.DateMonth;

namespace Ensersoft.Clients.Predictor.Abstractions.Models;

public record SetupModelRequest : BaseRegionRangeRequest
{
    public SetupModelRequest(int regionKey, DateMonthOnly fromDate, DateMonthOnly toDate) : base(regionKey, fromDate, toDate)
    {
    }
}
