namespace Ensersoft.Clients.Scrappers.Abstractions.Models.Common;

public class FactPriceQueryData
{
    public DateOnly Date { get; init; }
    public int RegionKey { get; init; }
    public ICollection<FactPriceProviderQueryData> ProviderPrices { get; init; }

    public FactPriceQueryData(DateOnly date, int regionKey, ICollection<FactPriceProviderQueryData> providerPrices)
    {
        Date = date;
        RegionKey = regionKey;
        ProviderPrices = providerPrices;
    }
}
