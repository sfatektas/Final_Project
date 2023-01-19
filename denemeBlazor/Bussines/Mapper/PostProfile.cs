using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Models;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Mapper
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
