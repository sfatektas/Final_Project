using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Data.Entities;

namespace denemeBlazor.Bussines.Mapper
{
    public class AppRoleProfile : Profile
    {
        public AppRoleProfile()
        {
            CreateMap<AppRole, AppRoleListDto>().ReverseMap();
        }
    }
}
