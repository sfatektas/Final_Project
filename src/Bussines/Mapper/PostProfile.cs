using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Models;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Mapper
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostCreateDto>().ReverseMap();
            CreateMap<PostAddModel, PostCreateDto>();
            CreateMap<PostUpdateModel, PostListDto>().ReverseMap();
            CreateMap<PostUpdateModel, PostUpdateDto>().ReverseMap();
            CreateMap<Post, PostListDto>().ReverseMap();
            CreateMap<Post, PostUpdateDto>().ReverseMap();
        }
    }
}
