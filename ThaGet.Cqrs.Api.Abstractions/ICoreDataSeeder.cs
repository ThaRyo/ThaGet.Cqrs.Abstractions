using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Api.Abstractions
{
    public interface ICoreDataSeeder<T, TId> : IDataSeeder<T, TId>
        where T : IEntity<TId>
        where TId : struct
    {
    }
}
