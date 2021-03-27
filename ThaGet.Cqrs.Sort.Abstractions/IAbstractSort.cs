using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Sort.Abstractions
{
    public interface IAbstractSort<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        Dictionary<string, ISortDefinition<TEntity, TId>> Entries { get; }

        void CreateEntry(string query, Expression<Func<TEntity, object>> predicate);
    }
}
