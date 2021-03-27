using System;
using System.Linq.Expressions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;
using ThaGet.Cqrs.Filter.Core.Enums;

namespace ThaGet.Cqrs.Filter.Abstractions
{
    public interface IFilterDefinition<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        string Name { get; set; }
        FilterType Type { get; set; }
        Expression<Func<TEntity, object>> Predicate { get; set; }
    }
}