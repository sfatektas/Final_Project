using MSS_NewsWeb.Common;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Context;
using SportsStore.Data.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace MSS_NewsWeb.Data.Repository
{
    public class Repository<T> where T : BaseEntity
    {
        readonly NewsDbContext _context;

        public Repository(NewsDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<T> FindAsync(object id)
        {
            var data = await _context.Set<T>().FindAsync(id);
            return data;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var list = await _context.Set<T>().AsNoTracking().ToListAsync();
            return list;
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter )
        {
            var list = await _context.Set<T>().AsNoTracking().Where(filter).ToListAsync();
            return list;
        }
        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T,TKey>> keySelector, OrderByType OrderByType = OrderByType.DESC)
        {
            var list = (OrderByType == OrderByType.DESC) ? await _context.Set<T>().AsNoTracking().OrderByDescending(keySelector).Where(filter).ToListAsync() :
                await _context.Set<T>().AsNoTracking().OrderBy(keySelector).Where(filter).ToListAsync();
            return list;
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, bool asNoTracking = false)
        {
            return !asNoTracking ? await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter) :
                await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T unchanged, T updated)
        {
            _context.Update(updated);
            //_context.Entry(unchanged).CurrentValues.SetValues(updated);
        }
        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }
        public IQueryable<T> GetQueryable(int id)
        {
            return _context.Set<T>().AsQueryable().Where(x => x.Id == id);
        }
       

    }
}
