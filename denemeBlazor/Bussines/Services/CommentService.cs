using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Common;
using MSS_NewsWeb.Common.Interfaces;
using MSS_NewsWeb.Data.Interfaces;
using MSS_NewsWeb.Services;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Services
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

        public Task<IResponse<CommentListDto>> GetQueryable(int id)
        {
            throw new NotImplementedException();
        }
    }
}
