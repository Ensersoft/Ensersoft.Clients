using Ensersoft.Clients.WebApi.Abstractions.Models.Common;

namespace Ensersoft.Clients.WebApi.Abstractions.Models;

public record GetPlannedPeakHoursResponse
{
    public PeakHoursData Data { get; init; } = default!;
}
