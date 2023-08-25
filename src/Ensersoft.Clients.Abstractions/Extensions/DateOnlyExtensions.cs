namespace Ensersoft.Clients.Abstractions.Extensions;

public static class DateOnlyExtensions
{
    public static DateOnly GetLastDayOfMonth(this DateOnly dateOnly)
    {
        return new DateOnly(dateOnly.Year, dateOnly.Month, 1).AddMonths(1).AddDays(-1);
    }
}
