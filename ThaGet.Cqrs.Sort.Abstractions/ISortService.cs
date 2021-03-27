using System.Collections.Generic;
using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Sort.Abstractions
{
    public interface ISortService<TId>
        where TId : struct
    {
        void AddSort<TQuery, TEntity>(ISortExpression<TEntity, TId> expression)
        where TQuery : class
        where TEntity : IEntity<TId>;
        IReadOnlyCollection<ISortDefinition<TEntity, TId>> GetSortList<TQuery, TEntity>()
        where TQuery : class
        where TEntity : IEntity<TId>;
    }
}