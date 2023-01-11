using denemeBlazor.Data.Repository;
using SportsStore.Data.Entities;

namespace denemeBlazor.Data.Interfaces
{
    public interface IUow
    {
        public Repository<T> GetRepository<T>() where T : BaseEntity;

        public Task SaveChangesAsync();
    }
}
