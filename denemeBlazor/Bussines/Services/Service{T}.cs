using denemeBlazor.Data.Interfaces;
using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Services
{
    public class Service<CreateDto, ListDto, UpdateDto, Entity> where CreateDto : class , ICreateDto
        where ListDto : class, IListDto  
        where UpdateDto : class, IUpdateDto
        where Entity : BaseEntity
    {
        readonly IUow _uow;

        public Service(IUow uow)
        {
            _uow = uow;
        }
        //public async Task<List<ListDto>> GetAllAsync()
        //{
        //    return await _uow.GetRepository<Entity>().GetAllAsync();
        //}
    }
}
