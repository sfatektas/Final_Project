using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Data.Entities
{
    public class AppRole : BaseEntity
    {
        public string Defination { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
