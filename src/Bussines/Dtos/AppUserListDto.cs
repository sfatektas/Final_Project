using MSS_NewsWeb.Services.Interfaces;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Dtos
{
    public class AppUserListDto : IListDto
    {
        public int Id { get ; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int AppRoleId { get; set; }

        public AppRoleListDto AppRole { get; set; }
    }
}
