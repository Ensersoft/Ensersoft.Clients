namespace Ensersoft.Clients.Scrappers.Abstractions.Models.Common;

public record FactHourData
{
    public DateOnly Date { get; set; }
    public int NormalizedFactHour { get; set; }

}