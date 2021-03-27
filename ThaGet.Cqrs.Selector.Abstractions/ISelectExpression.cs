using System.Linq;
using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Selector.Abstractions
{
    public interface ISelectExpression<TSoruce, TResult, TId>
        where TSoruce : IEntity<TId>
        where TId : struct
    {
        IQueryable<TResult> Apply(IQueryable<TSoruce> query);
    }
}