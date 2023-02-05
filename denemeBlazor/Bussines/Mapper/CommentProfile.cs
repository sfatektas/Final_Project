using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Mapper
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentCreateDto>().ReverseMap();
            CreateMap<Comment, CommentListDto>().ReverseMap();
            CreateMap<Comment, CommentUpdateDto>().ReverseMap();
        }
    }
}
