using Ensersoft.Clients.Common.DateMonth;

namespace Ensersoft.Clients.Predictor.Abstractions.Models;

public record SetupModelRequest : BaseRegionRangeRequest
{
    public SetupModelRequest(string region, DateMonthOnly fromDate, DateMonthOnly toDate) : base(region, fromDate, toDate)
    {
    }
}
