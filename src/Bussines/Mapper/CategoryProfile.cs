using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Mapper
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
