using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Data.Entities;
using denemeBlazor.Services.Interfaces;

namespace denemeBlazor.Bussines.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto,AppUserListDto,AppUserUpdateDto,AppUser>, IQueryable<AppUserListDto>
    {
        
    }
}
