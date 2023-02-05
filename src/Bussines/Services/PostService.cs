using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Common;
using MSS_NewsWeb.Common.Interfaces;
using MSS_NewsWeb.Data.Interfaces;
using MSS_NewsWeb.Services;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Entities;
using System.Security.Cryptography.X509Certificates;

namespace MSS_NewsWeb.Bussines.Services
{
    public class PostService : Service<PostCreateDto, PostListDto, PostUpdateDto, Post>, IPostService
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        public PostService(IUow uow, IMapper mapper, IValidator<PostCreateDto> createValidator) : base(uow, mapper, createValidator)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public Task<IResponse<List<PostListDto>>> GetAllQueryable()
        {
            throw new NotImplementedException();
        }

        public async Task<IResponse<PostListDto>> GetQueryable(int id)
        {
            var data =  _uow.GetRepository<Post>().GetQueryable().Where(x=> x.Id == id).Include(x => x.Category).Include(x=>x.AppUser).FirstOrDefault();
            return new Response<PostListDto>(ResponseType.Success, _mapper.Map<PostListDto>( data));
        }
    }
}
