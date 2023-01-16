using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Common;
using denemeBlazor.Common.Interfaces;
using denemeBlazor.Data.Interfaces;
using denemeBlazor.Services;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Services
{
    public class CommentService : Service<CommentCreateDto, CommentListDto, CommentUpdateDto, Comment> , ICommentService
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        public CommentService(IUow uow, IMapper mapper, IValidator<CommentCreateDto> createValidator) : base(uow, mapper, createValidator)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IResponse<List<CommentListDto>>> GetAllQueryable()
        {
            var comments = await _uow.GetRepository<Comment>().GetQueryable().Include(x=>x.AppUser).Include(x=>x.Post).AsNoTracking().ToListAsync();
            return new Response<List<CommentListDto>>(ResponseType.Success, _mapper.Map<List<CommentListDto>>(comments));
        }
        public async Task<IResponse<List<CommentListDto>>> GetNewsAllCommantsWithPostId(int id)
        {
            var comments = await _uow.GetRepository<Comment>().GetQueryable().Include(x => x.AppUser).Include(x => x.Post).Where(x=>x.PostId==id).AsNoTracking().ToListAsync();
            return new Response<List<CommentListDto>>(ResponseType.Success, _mapper.Map<List<CommentListDto>>(comments));
        }


        public Task<IResponse<CommentListDto>> GetQueryable()
        {
            throw new NotImplementedException();
        }

        

    }
}
