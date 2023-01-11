using denemeBlazor.Common.Interfaces;
using denemeBlazor.Data.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Services.Interfaces
{
    public interface IService<CreateDto, ListDto, UpdateDto, Entity> where CreateDto : class, ICreateDto
        where ListDto : class, IListDto
        where UpdateDto : class, IUpdateDto
        where Entity : BaseEntity
    {
        Task<IResponse<List<ListDto>>> GetAllAsync();
    }
}
