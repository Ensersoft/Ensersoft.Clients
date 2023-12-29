using Ensersoft.Clients.Scrappers.Abstractions.Models.Common;

namespace Ensersoft.Clients.Scrappers.Abstractions.Models;

public record GetFactHoursResponse
{
    public ICollection<FactHourData> Items { get; init; } = default!;
}
