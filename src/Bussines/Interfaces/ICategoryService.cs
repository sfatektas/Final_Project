using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Services.Interfaces;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Interfaces
{
    public interface ICategoryService : IService<CategoryCreateDto,CategoryListDto,CategoryUpdateDto,Category>
    {
    }
}
