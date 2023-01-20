using denemeBlazor.Common;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Context;
using SportsStore.Data.Entities;
using System.Linq.Expressions;

namespace denemeBlazor.Data.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);

        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> keySelector, OrderByType OrderByType = OrderByType.DESC);
        Task CreateAsync(T entity);

        Task<T> FindAsync(object id);

        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, bool asNoTracking = false);

        void Remove(T entity);

        void Update(T unchanged, T updated);

        IQueryable<T> GetQueryable();

        IQueryable<T> GetQueryable(int id);
    }
}
