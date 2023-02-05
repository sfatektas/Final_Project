using MSS_NewsWeb.Services.Interfaces;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Dtos
{
    public class CategoryListDto : IListDto
    {
        public int Id { get; set; }

        public string Defination { get; set; }

    }
}
