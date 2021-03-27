using System;
using System.Linq.Expressions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;
using ThaGet.Cqrs.Sort.Core.Enums;

namespace ThaGet.Cqrs.Sort.Abstractions
{
    public interface ISortRule<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        SortDirection Direction { get; }
        Expression<Func<TEntity, object>> Expression { get; }
    }
}