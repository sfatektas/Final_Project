using denemeBlazor.Common;
using denemeBlazor.Common.Interfaces;
using denemeBlazor.Data.Interfaces;
using SportsStore.Data.Entities;
using System.Linq.Expressions;

namespace denemeBlazor.Services.Interfaces
{
    public interface IService<CreateDto, ListDto, UpdateDto, T> where CreateDto : class, ICreateDto
        where ListDto : class, IListDto
        where UpdateDto : class, IUpdateDto
        where T : BaseEntity
    {

        Task<IResponse<CreateDto>> CreateAsync(CreateDto model);

        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto model);

        Task<IResponse<ListDto>> GetByIdAsync(int id) ;

        Task<IResponse<ListDto>> GetByFilterAsync(Expression<Func<T, bool>> filter);

        Task<IResponse> RemoveAsync(ListDto dto);

        Task<IResponse<List<ListDto>>> GetAllAsync();

        Task<IResponse<List<ListDto>>> GetAllAsync(Expression<Func<T, bool>> filter);
    
    }
}
