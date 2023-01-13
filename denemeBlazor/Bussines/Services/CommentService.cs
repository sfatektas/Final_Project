using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Data.Interfaces;
using denemeBlazor.Services;
using FluentValidation;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Services
{
    public class CommentService : Service<CommentCreateDto, CommentListDto, CommentUpdateDto, Comment>
    {
        public CommentService(IUow uow, IMapper mapper, IValidator<CommentCreateDto> createValidator) : base(uow, mapper, createValidator)
        {
        }
    }
}
