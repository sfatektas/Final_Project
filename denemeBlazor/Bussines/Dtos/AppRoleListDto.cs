using MSS_NewsWeb.Services.Interfaces;

namespace MSS_NewsWeb.Bussines.Dtos
{
    public class AppRoleListDto : IListDto
    {
        public int Id { get; set ; }

        public string Defination { get; set; }

    }
}
