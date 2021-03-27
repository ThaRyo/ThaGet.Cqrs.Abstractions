using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;
using ThaGet.Cqrs.Sort.Core.Enums;

namespace ThaGet.Cqrs.Sort.Abstractions
{
    public interface ISortExpression<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        void Add(Expression<Func<TEntity, object>> rule, SortDirection direction);
        void Add(ISortInfo info);
        void Add(ISortRule<TEntity, TId> rule);
        void AddRange(IEnumerable<ISortInfo> infoList);
        void AddRange(IEnumerable<ISortRule<TEntity, TId>> infoList);
        void AddVariable(string name, Expression<Func<TEntity, object>> expression);
        IQueryable<TEntity> Apply(IQueryable<TEntity> query);
        void SetDefault(ISortRule<TEntity, TId> rule);

    }
}
