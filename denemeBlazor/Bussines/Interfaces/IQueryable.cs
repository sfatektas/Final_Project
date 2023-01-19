using denemeBlazor.Common.Interfaces;
using denemeBlazor.Services.Interfaces;

namespace denemeBlazor.Bussines.Interfaces
{
    public interface IQueryable<ListDto> where ListDto : class ,IListDto
    {
        Task<IResponse<List<ListDto>>> GetAllQueryable();
        Task<IResponse<ListDto>> GetQueryable(int id);
    }
}
