using SportsStore.Data.Context;
using SportsStore.Data.Entities;

namespace denemeBlazor.Data.Repository
{
    public class Repository<T> where T : BaseEntity
    {
        readonly NewsDbContext _context;

        public Repository(NewsDbContext context)
        {
            _context = context;
        }

    }
}
