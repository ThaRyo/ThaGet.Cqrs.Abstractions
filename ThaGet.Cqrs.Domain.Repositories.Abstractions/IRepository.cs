using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThaGet.Cqrs.Contract.Abstractions;
using ThaGet.Cqrs.Domain.Entities.Abstractions;
using ThaGet.Cqrs.Filter.Abstractions;
using ThaGet.Cqrs.Include.Abstractions;
using ThaGet.Cqrs.Selector.Abstractions;
using ThaGet.Cqrs.Sort.Abstractions;

namespace ThaGet.Cqrs.Domain.Repositories.Abstractions
{
    public interface IRepository<TEntity, TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        IUnitOfWork UnitOfWork { get; }

        TEntity Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        Task<bool> Exists(TId id);
        Task<ICollection<TEntity>> GetAllAsync(bool trackEntities = false);

        Task<TEntity> GetByIdAsync(TId id);
        Task<TEntity> GetByIdAsync(TId id, IIncludeExpression<TEntity, TId> includeExpression);
        Task<TResult> GetByIdAsync<TResult>(TId id, ISelectExpression<TEntity, TResult, TId> selectExpression)
            where TResult : class;
        Task<TResult> GetByIdAsync<TResult>(TId id, ISelectExpression<TEntity, TResult, TId> selectExpression, IIncludeExpression<TEntity, TId> includeExpression)
            where TResult : class;

        Task<TEntity> GetByAsync(IFilterExpression<TEntity, TId> filterExpression);
        Task<TResult> GetByAsync<TResult>(ISelectExpression<TEntity, TResult, TId> selectExpression, IFilterExpression<TEntity, TId> filterExpression)
            where TResult : class;
        Task<TResult> GetByAsync<TResult>(ISelectExpression<TEntity, TResult, TId> selectExpression, IIncludeExpression<TEntity, TId> includeExpression, IFilterExpression<TEntity, TId> filterExpression)
            where TResult : class;

        Task<TEntity> FindByIdAsync(TId id);
        Task<TEntity> FindByIdAsync(TId id, IIncludeExpression<TEntity, TId> includeExpression);
        Task<TResult> FindByIdAsync<TResult>(TId id, ISelectExpression<TEntity, TResult, TId> selectExpression)
            where TResult : class;
        Task<TResult> FindByIdAsync<TResult>(TId id, ISelectExpression<TEntity, TResult, TId> selectExpression, IIncludeExpression<TEntity, TId> includeExpression)
            where TResult : class;

        Task<TEntity> FindByAsync(IFilterExpression<TEntity, TId> filterExpression);
        Task<TResult> FindByAsync<TResult>(ISelectExpression<TEntity, TResult, TId> selectExpression, IFilterExpression<TEntity, TId> filterExpression)
            where TResult : class;
        Task<TResult> FindByAsync<TResult>(ISelectExpression<TEntity, TResult, TId> selectExpression, IIncludeExpression<TEntity, TId> includeExpression, IFilterExpression<TEntity, TId> filterExpression)
            where TResult : class;

        Task<ICollection<TEntity>> FindAllByAsync(IIncludeExpression<TEntity, TId> includeExpression, IFilterExpression<TEntity, TId> filterExpression);
        Task<ICollection<TResult>> FindAllByAsync<TResult>(ISelectExpression<TEntity, TResult, TId> selectExpression, IFilterExpression<TEntity, TId> filterExpression)
            where TResult : class;
        Task<ICollection<TResult>> FindAllByAsync<TResult>(ISelectExpression<TEntity, TResult, TId> selectExpression, IIncludeExpression<TEntity, TId> includeExpression, IFilterExpression<TEntity, TId> filterExpression)
            where TResult : class;
        Task<ICollection<TResult>> FindAllByAsync<TResult>(ISelectExpression<TEntity, TResult, TId> selectExpression, IIncludeExpression<TEntity, TId> includeExpression, IFilterExpression<TEntity, TId> filterExpression, ISortExpression<TEntity, TId> sortExpression)
            where TResult : class;

        Task<IPagination<TResultType>> GetPaginationAsync<TResultType>(ISelectExpression<TEntity, TResultType, TId> selectExpression, IIncludeExpression<TEntity, TId> includeExpression, IFilterExpression<TEntity, TId> filterExpression, ISortExpression<TEntity, TId> sortExpression, int skip, int take)
            where TResultType : class;

        Task<TProperty> LazyLoad_NEW<TSomeEntity, TProperty>(TSomeEntity entity, Expression<Func<TSomeEntity, TProperty>> propertyExpression)
            where TSomeEntity : class, IEntity<TId>
            where TProperty : class;
        Task<TProperty> LazyLoad_OLD<TSomeEntity, TProperty>(TSomeEntity entity, Expression<Func<TSomeEntity, TProperty>> propertyExpression)
            where TSomeEntity : class, IEntity<TId>
            where TProperty : class;

        void UpdateReferences<TRef>(TEntity entity, Func<TEntity, ICollection<TRef>> references, Func<TRef, IComparable> getIdFunc, IEnumerable<TRef> newValues, Action<TRef, TRef> updateAction = null, Func<TRef, TRef, bool> isModifiedFunc = null, Action<TRef> deleteAction = null)
            where TRef : class, IEntity<TId>;
        void UpdateReferences<TRef>(TEntity entity, Func<TEntity, ICollection<TRef>> references, Func<TRef, IComparable> getIdFunc, IEnumerable<TRef> toAdd, IEnumerable<TRef> toRemove, IEnumerable<TRef> toUpdate, Action<TRef, TRef> updateAction = null, Action<TRef> deleteAction = null)
            where TRef : class, IEntity<TId>;
    }
}
