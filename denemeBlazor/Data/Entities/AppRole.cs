using SportsStore.Data.Entities;

namespace denemeBlazor.Data.Entities
{
    public class AppRole : BaseEntity
    {
        public string Defination { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
