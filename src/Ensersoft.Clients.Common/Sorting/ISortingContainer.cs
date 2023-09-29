namespace Ensersoft.Clients.Common.Sorting;

public interface ISortingContainer
{
    IReadOnlyCollection<SortingBy>? Sortings { get; }
    IReadOnlySet<string> GetPropertyKeys();
}
