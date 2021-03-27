using System.Threading;
using System.Threading.Tasks;

namespace ThaGet.Cqrs.Domain.Repositories.Abstractions
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAllChangesAsync(CancellationToken cancellationToken = default);
    }
}
