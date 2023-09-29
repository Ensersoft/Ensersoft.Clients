using System.Linq.Expressions;

namespace Ensersoft.Clients.Common.Sorting;

public interface IOrderingQuery<TEntity> : ISortingContainer
{
    IReadOnlyDictionary<string, Expression<Func<TEntity, object?>>> GetOrderingPropertyMappings();
    IReadOnlyCollection<OrderByFunction<TEntity>> GetDefaultOrdering();
}
