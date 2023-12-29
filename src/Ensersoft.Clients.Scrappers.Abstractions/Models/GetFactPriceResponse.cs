using Ensersoft.Clients.Scrappers.Abstractions.Models.Common;

namespace Ensersoft.Clients.Scrappers.Abstractions.Models;

public record GetFactPriceResponse
{
    public ICollection<FactPriceQueryData> Items { get; init; } = default!;
}
