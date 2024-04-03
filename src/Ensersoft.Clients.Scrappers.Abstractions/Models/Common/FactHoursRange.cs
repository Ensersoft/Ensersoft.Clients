namespace Ensersoft.Clients.Scrappers.Abstractions.Models.Common;

public class FactHoursRange
{
    public int RegionKey { get; set; }
    public DateOnly FirstDay { get; set; }
    public DateOnly LastDay { get; set; }
}
