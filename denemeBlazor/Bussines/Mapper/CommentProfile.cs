using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Mapper
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
