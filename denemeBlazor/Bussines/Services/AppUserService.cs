using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Common;
using denemeBlazor.Common.Interfaces;
using denemeBlazor.Data.Entities;
using denemeBlazor.Data.Interfaces;
using denemeBlazor.Services;
using denemeBlazor.Services.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace denemeBlazor.Bussines.Services
{
    public class AppUserService : Service<AppUserCreateDto,AppUserListDto,AppUserUpdateDto,AppUser>,IAppUserService
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        public AppUserService(IUow uow ,IMapper mapper, IValidator<AppUserCreateDto> createValidator) : base(uow ,mapper,createValidator)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IResponse<List<AppUserListDto>>> GetAllQueryable()
        {
            var data = _uow.GetRepository<AppUser>().GetQueryable().Include(x => x.AppRole).Include(x => x.Posts).Include(x => x.Comments);
            return new Response<List<AppUserListDto>>(ResponseType.Success, _mapper.Map<List<AppUserListDto>>(await data.ToListAsync()));
        }

        public Task<IResponse<AppUserListDto>> GetQueryable(int id)
        {
            throw new NotImplementedException();
        }
    }
}
