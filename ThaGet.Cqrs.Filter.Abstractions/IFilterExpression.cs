using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Filter.Abstractions
{
    public interface IFilterExpression<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        void Add(Expression<Func<TEntity, bool>> rule);
        void Add(IFilterInfo info);
        void AddRange(IEnumerable<Expression<Func<TEntity, bool>>> ruleList);
        void AddRange(IEnumerable<IFilterInfo> infoList);
        void AddVariable(string name, Expression<Func<TEntity, object>> expression);
        IQueryable<TEntity> Apply(IQueryable<TEntity> query);
        IEnumerator<Expression<Func<TEntity, bool>>> GetEnumerator();
    }
}