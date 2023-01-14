using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Interfaces
{
    public interface IPostService : IService<PostCreateDto,PostListDto,PostUpdateDto,Post>
    {
    }
}
