using System.Collections.Generic;
using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Filter.Abstractions
{
    public interface IFilterService<TId>
        where TId : struct
    {
        IReadOnlyCollection<IFilterDefinition<TEntity, TId>> GetFilterList<TQuery, TEntity>()
            where TQuery : class
            where TEntity : IEntity<TId>;

        void AddFilter<TQuery, TEntity>(IFilterExpression<TEntity, TId> expression)
            where TQuery : class
            where TEntity : IEntity<TId>;
    }
}