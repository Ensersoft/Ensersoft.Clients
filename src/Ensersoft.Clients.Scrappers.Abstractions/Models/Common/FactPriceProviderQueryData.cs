namespace Ensersoft.Clients.Scrappers.Abstractions.Models.Common;

public class FactPriceProviderQueryData
{
    public double Price { get; init; }
    public string ProviderKey { get; init; }

    public FactPriceProviderQueryData(string providerKey, double price)
    {
        ProviderKey = providerKey;
        Price = price;
    }
}
