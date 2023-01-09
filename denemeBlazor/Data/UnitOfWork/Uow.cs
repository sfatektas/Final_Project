using denemeBlazor.Data.Interfaces;
using denemeBlazor.Data.Repository;
using SportsStore.Data.Context;
using SportsStore.Data.Entities;

namespace denemeBlazor.Data.UnitOfWork
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

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
