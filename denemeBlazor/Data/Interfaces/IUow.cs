using MSS_NewsWeb.Data.Repository;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Data.Interfaces
{
    public interface IUow
    {
        public Repository<T> GetRepository<T>() where T : BaseEntity;

        public Task SaveChangesAsync();
    }
}
