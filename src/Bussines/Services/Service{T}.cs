using AutoMapper;
using MSS_NewsWeb.Bussines.Extensions;
using MSS_NewsWeb.Common;
using MSS_NewsWeb.Common.Interfaces;
using MSS_NewsWeb.Data.Interfaces;
using MSS_NewsWeb.Services.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Entities;
using System.Linq.Expressions;

namespace MSS_NewsWeb.Services
{
    public class Service<CreateDto, ListDto, UpdateDto, T> :IService<CreateDto , ListDto , UpdateDto , T>
        where CreateDto : class , ICreateDto
        where ListDto : class, IListDto  
        where UpdateDto : class, IUpdateDto
        where T : BaseEntity
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        readonly IValidator<CreateDto> _createValidator;
        //Update Validator eklenecek



        public Service(IUow uow, IMapper mapper, IValidator<CreateDto> createValidator)
        {
            _uow = uow;
            _mapper = mapper;
            _createValidator = createValidator;
        }
        public async Task<IResponse<List<ListDto>>> GetAllAsync()
        {
            var data = await _uow.GetRepository<T>().GetAllAsync();
            if (data != null)
                return new Response<List<ListDto>>(ResponseType.Success, _mapper.Map<List<ListDto>>(data));
            else
                return new Response<List<ListDto>>(ResponseType.NotFound, _mapper.Map<List<ListDto>>(data));
        }

        public async Task<IResponse<CreateDto>> CreateAsync(CreateDto dto)
        {
            var result = await _createValidator.ValidateAsync(dto);
            if (result.IsValid)
            {
                await _uow.GetRepository<T>().CreateAsync(_mapper.Map<T>(dto));
                await _uow.SaveChangesAsync();
                return new Response<CreateDto>(ResponseType.Success, dto);
            }
            else
                return new Response<CreateDto>(ResponseType.ValidationError,"validasyon hatası", dto, result.GetValidationErrors());
        }

        public async Task<IResponse<List<ListDto>>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            var result = await _uow.GetRepository<T>().GetAllAsync(filter);
            return new Response<List<ListDto>>(ResponseType.Success, _mapper.Map<List<ListDto>>(result));
        }

        public async Task<IResponse<ListDto>> GetByIdAsync(int id)
        {
            var data = await _uow.GetRepository<T>().GetByFilterAsync(x => x.Id == id);
            if (data != null)
            {
                return new Response<ListDto>(ResponseType.Success, _mapper.Map<ListDto>(data));
            }
            return new Response<ListDto>(ResponseType.NotFound, "Böyle bir kayıta ulaşılamadı.", _mapper.Map<ListDto>(data));
        }

        public async Task<IResponse> RemoveAsync(ListDto dto)
        {
            _uow.GetRepository<T>().Remove(_mapper.Map<T>(dto));
            await _uow.SaveChangesAsync();
            return new Response(ResponseType.Success);
        }

        public async Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto)
        {
            try
            {
                _uow.GetRepository<T>().Update(await _uow.GetRepository<T>().GetByFilterAsync(x => x.Id == dto.Id), _mapper.Map<T>(dto));
                await _uow.SaveChangesAsync();
                return new Response<UpdateDto>(ResponseType.Success, dto);
            }
            catch (Exception e)
            {
                return new Response<UpdateDto>(ResponseType.Error, $"Bir sorun oluştu Hata mesajı : {e.Message}", dto);
            }
        }

        public async Task<IResponse<ListDto>> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
                var data = await _uow.GetRepository<T>().GetByFilterAsync(filter);
                if (data == null)
                    return new Response<ListDto>(ResponseType.NotFound, _mapper.Map<ListDto>(data));

            return new Response<ListDto>(ResponseType.Success, _mapper.Map<ListDto>(data));
        }
        
    }
}
