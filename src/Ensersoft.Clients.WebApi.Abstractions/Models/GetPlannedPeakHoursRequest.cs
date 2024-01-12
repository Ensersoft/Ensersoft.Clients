namespace Ensersoft.Clients.WebApi.Abstractions.Models;

public record GetPlannedPeakHoursRequest
{
    public int RegionKey { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }

    public GetPlannedPeakHoursRequest(int regionKey, int year, int month)
    {
        RegionKey = regionKey;
        Year = year;
        Month = month;
    }
}