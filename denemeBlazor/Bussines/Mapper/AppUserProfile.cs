using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Data.Entities;

namespace MSS_NewsWeb.Bussines.Mapper
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
