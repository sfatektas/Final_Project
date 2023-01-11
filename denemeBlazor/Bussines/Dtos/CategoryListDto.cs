using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Dtos
{
    public class CategoryListDto : IListDto
    {
        public int Id { get; set; }

        public string Defination { get; set; }

    }
}
