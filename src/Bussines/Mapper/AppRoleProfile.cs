using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Data.Entities;

namespace MSS_NewsWeb.Bussines.Mapper
{
    public class AppRoleProfile : Profile
    {
        public AppRoleProfile()
        {
            CreateMap<AppRole, AppRoleListDto>().ReverseMap();
        }
    }
}
