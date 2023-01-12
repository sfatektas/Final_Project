using denemeBlazor.Services.Interfaces;

namespace denemeBlazor.Bussines.Dtos
{
    public class AppUserCreateDto : ICreateDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int AppRoleId { get; set; }
    }
}
