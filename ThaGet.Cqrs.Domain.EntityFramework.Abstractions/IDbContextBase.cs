using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using ThaGet.Cqrs.Domain.Repositories.Abstractions;

namespace ThaGet.Cqrs.Domain.EntityFramework.Abstractions
{
    public interface IDbContextBase : IUnitOfWork, IDisposable
    {
        DatabaseFacade Database { get; }

        EntityEntry Entry([NotNull] object entity);
        EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity) where TEntity : class;

        DbSet<TEntity> Set<TEntity>([NotNull] string name) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        EntityEntry Add([NotNull] object entity);
        EntityEntry<TEntity> Add<TEntity>([NotNull] TEntity entity) where TEntity : class;

        EntityEntry Remove([NotNull] object entity);
        EntityEntry<TEntity> Remove<TEntity>([NotNull] TEntity entity) where TEntity : class;

        EntityEntry Update([NotNull] object entity);
        EntityEntry<TEntity> Update<TEntity>([NotNull] TEntity entity) where TEntity : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}