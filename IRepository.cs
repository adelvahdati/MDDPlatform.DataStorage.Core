using System.Linq.Expressions;
using MDDPlatform.SharedKernel.Entities;

namespace MDDPlatform.DataStorage.Core
{
    public interface IRepository<TEntity,TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> GetAsync(TId id);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        
        Task<IReadOnlyList<TEntity>> ListAsync();
        Task<IReadOnlyList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate);
        
        Task<long> CountAsync(Expression<Func<TEntity, bool>> predicate);

        Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate);
        
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteAync(TId Id);
    }
}