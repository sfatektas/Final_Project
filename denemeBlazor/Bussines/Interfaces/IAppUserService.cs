using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Data.Entities;
using MSS_NewsWeb.Services.Interfaces;

namespace MSS_NewsWeb.Bussines.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto,AppUserListDto,AppUserUpdateDto,AppUser>, IQueryable<AppUserListDto>
    {
        
    }
}
