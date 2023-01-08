using Microsoft.AspNetCore.Identity;
using SportsStore.Data.Entities;

namespace denemeBlazor.Data.Entities
{
    public class AppUser : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
