using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Data.Entities;

namespace denemeBlazor.Bussines.Mapper
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUser, AppUserListDto>().ReverseMap();
            CreateMap<AppUser, AppUserCreateDto>().ReverseMap();
            CreateMap<AppUserListDto, AppUserUpdateDto>().ReverseMap();
            CreateMap<AppUser, AppUserUpdateDto>().ReverseMap();

        }
    }
}
