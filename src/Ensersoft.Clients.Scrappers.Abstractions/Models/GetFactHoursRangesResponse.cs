using Ensersoft.Clients.Scrappers.Abstractions.Models.Common;

namespace Ensersoft.Clients.Scrappers.Abstractions.Models;

public record GetFactHoursRangesResponse
{
    public ICollection<FactHoursRange> Items { get; init; } = default!;
}
