using MSS_NewsWeb.Data.Interfaces;
using MSS_NewsWeb.Data.Repository;
using SportsStore.Data.Context;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Data.UnitOfWork
{
    public class Uow : IUow
    {
        readonly NewsDbContext _context;

        public Uow(NewsDbContext context)
        {
            _context = context;
        }

        public Repository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
             await _context.SaveChangesAsync();
        }
    }
}
