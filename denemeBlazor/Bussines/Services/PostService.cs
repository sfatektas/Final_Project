using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Data.Interfaces;
using denemeBlazor.Services;
using FluentValidation;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Services
{
    public class PostService : Service<PostCreateDto, PostListDto, PostUpdateDto, Post>, IPostService
    {
        public PostService(IUow uow, IMapper mapper, IValidator<PostCreateDto> createValidator) : base(uow, mapper, createValidator)
        {
        }
    }
}
