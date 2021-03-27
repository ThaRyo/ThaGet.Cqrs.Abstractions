using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Include.Abstractions
{
    public interface IIncludeExpression<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        ICollection<Expression<Func<TEntity, object>>> IncludeList { get; }
        void Add(Expression<Func<TEntity, object>> expression);
    }
}
