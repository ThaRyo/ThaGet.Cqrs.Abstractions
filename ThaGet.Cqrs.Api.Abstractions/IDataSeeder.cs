using ThaGet.Cqrs.Domain.Entities.Abstractions;

namespace ThaGet.Cqrs.Api.Abstractions
{
    public interface IDataSeeder<T, TId>
        where T : IEntity<TId>
        where TId : struct
    {
        void Seed();
    }
}
