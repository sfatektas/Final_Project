using AutoMapper;
using denemeBlazor.Common;
using denemeBlazor.Common.Interfaces;
using denemeBlazor.Data.Interfaces;
using denemeBlazor.Services.Interfaces;
using FluentValidation;
using SportsStore.Data.Entities;

namespace denemeBlazor.Services
{
    public class Service<CreateDto, ListDto, UpdateDto, Entity> where CreateDto : class , ICreateDto
        where ListDto : class, IListDto  
        where UpdateDto : class, IUpdateDto
        where Entity : BaseEntity
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        readonly IValidator<CreateDto> _createValidator;


        public Service(IUow uow, IMapper mapper, IValidator<CreateDto> createValidator)
        {
            _uow = uow;
            _mapper = mapper;
            _createValidator = createValidator;
        }
        public async Task<IResponse<List<ListDto>>> GetAllAsync()
        {
            var data = await _uow.GetRepository<Entity>().GetAllAsync();
            if (data != null)
                return new Response<List<ListDto>>(ResponseType.Success, _mapper.Map<List<ListDto>>(data));
            else
                return new Response<List<ListDto>>(ResponseType.NotFound, _mapper.Map<List<ListDto>>(data));
        }
    }
}
