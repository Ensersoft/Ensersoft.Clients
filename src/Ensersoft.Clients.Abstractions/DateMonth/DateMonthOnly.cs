namespace Ensersoft.Clients.Abstractions.DateMonth;

public struct DateMonthOnly : IEquatable<DateMonthOnly>
{
    public int Year { get; set; }
    public int Month { get; set; }

    public DateMonthOnly(int year, int month)
    {
        Year = year;
        Month = month;
    }

    public static DateMonthOnly FromDateOnly(DateOnly dateOnly)
    {
        return new DateMonthOnly(dateOnly.Year, dateOnly.Month);
    }

    public static DateMonthOnly FromDateTime(DateTime dateTime)
    {
        return new DateMonthOnly(dateTime.Year, dateTime.Month);
    }

    public override readonly int GetHashCode()
    {
        return HashCode.Combine(Year, Month);
    }

    public static bool operator ==(DateMonthOnly left, DateMonthOnly right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(DateMonthOnly left, DateMonthOnly right)
    {
        return !(left == right);
    }

    public readonly bool Equals(DateMonthOnly other)
    {
        return Equals(Year, other.Year) && Equals(Month, other.Month);
    }

    public override readonly bool Equals(object? obj)
    {
        var right = obj as DateMonthOnly?;
        if (right == null)
        {
            return false;
        }
        return Equals(right.Value);
    }
}
