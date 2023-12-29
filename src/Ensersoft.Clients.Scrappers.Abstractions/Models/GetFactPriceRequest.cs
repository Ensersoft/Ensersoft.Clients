namespace Ensersoft.Clients.Scrappers.Abstractions.Models;

public record GetFactPriceRequest
{
    public int RegionKey { get; set; }
    public DateOnly FromDate { get; set; }
    public DateOnly ToDate { get; set; }

    public GetFactPriceRequest(int regionKey, DateOnly fromDate, DateOnly toDate)
    {
        RegionKey = regionKey;
        FromDate = fromDate;
        ToDate = toDate;
    }
}