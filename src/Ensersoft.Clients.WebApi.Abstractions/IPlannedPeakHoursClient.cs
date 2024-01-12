using Ensersoft.Clients.WebApi.Abstractions.Models;

namespace Ensersoft.Clients.WebApi.Abstractions;

public interface IPlannedPeakHoursClient
{
    Task<GetPlannedPeakHoursResponse> GetPlannedPeakHours(GetPlannedPeakHoursRequest request,
        CancellationToken cancellationToken = default);
}
