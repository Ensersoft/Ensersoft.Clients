namespace Ensersoft.Clients.Scrappers.Abstractions.Models;

public record GetFactHoursRequest
{
    public int RegionKey { get; set; }
    public DateOnly FromDate { get; set; }
    public DateOnly ToDate { get; set; }

    public GetFactHoursRequest(int regionKey, DateOnly fromDate, DateOnly toDate)
    {
        RegionKey = regionKey;
        FromDate = fromDate;
        ToDate = toDate;
    }
}