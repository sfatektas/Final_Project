using MSS_NewsWeb.Common.Interfaces;
using MSS_NewsWeb.Services.Interfaces;

namespace MSS_NewsWeb.Bussines.Interfaces
{
    public interface IQueryable<ListDto> where ListDto : class ,IListDto
    {
        Task<IResponse<List<ListDto>>> GetAllQueryable();
        Task<IResponse<ListDto>> GetQueryable(int id);
    }
}
