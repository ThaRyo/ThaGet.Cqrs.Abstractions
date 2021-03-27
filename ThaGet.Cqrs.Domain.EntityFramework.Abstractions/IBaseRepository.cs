using ThaGet.Cqrs.Domain.Entities.Abstractions;
using ThaGet.Cqrs.Domain.Repositories.Abstractions;

namespace ThaGet.Cqrs.Domain.EntityFramework.Abstractions
{
    public interface IBaseRepository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        IDbContextBase Context { get; }
    }
}