using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Mapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
            CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
