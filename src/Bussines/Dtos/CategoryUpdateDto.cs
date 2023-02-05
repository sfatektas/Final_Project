using MSS_NewsWeb.Services.Interfaces;

namespace MSS_NewsWeb.Bussines.Dtos
{
    public class CategoryUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public string Defination { get; set; }

    }
}
