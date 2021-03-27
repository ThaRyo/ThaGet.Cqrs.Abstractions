using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;
using ThaGet.Cqrs.Filter.Core.Enums;

namespace ThaGet.Cqrs.Filter.Abstractions
{
    public interface IFilter<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        Dictionary<string, IFilterDefinition<TEntity, TId>> Entries { get; set; }

        void CreateEntry(string query, FilterType type, Expression<Func<TEntity, object>> predicate);
    }
}