namespace Ensersoft.Clients.WebApi.Abstractions.Models.Common;

public record PeakHoursData
{
    public int RangeStart { get; set; }
    public int RangeEnd { get; set; }
    public int? RangeSecondStart { get; set; }
    public int? RangeSecondEnd { get; set; }
}
