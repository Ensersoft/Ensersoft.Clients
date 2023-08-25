using Ensersoft.Clients.Abstractions.DateMonth;

namespace Ensersoft.Clients.Abstractions.Predictor.Models;

public record SetupModelRequest : BaseRegionRangeRequest
{
    public SetupModelRequest(string region, DateMonthOnly fromDate, DateMonthOnly toDate) : base(region, fromDate, toDate)
    {
    }
}
