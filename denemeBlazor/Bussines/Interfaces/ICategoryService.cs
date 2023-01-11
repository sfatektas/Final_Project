using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Interfaces
{
    public interface ICategoryService : IService<CategoryCreateDto,CategoryListDto,CategoryUpdateDto,Category>
    {
    }
}
