using System;
using System.Linq.Expressions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Sort.Abstractions
{
    public interface ISortDefinition<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        string Name { get; set; }
        Expression<Func<TEntity, object>> Predicate { get; set; }
    }
}
