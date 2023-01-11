using AutoMapper;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Common.Interfaces;
using denemeBlazor.Data.Interfaces;
using denemeBlazor.Services;
using FluentValidation;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Services
{
    public class CategoryService : Service<CategoryCreateDto, CategoryListDto, CategoryUpdateDto, Category>, ICategoryService
    {
        public CategoryService(IUow uow, IMapper mapper, IValidator<CategoryCreateDto> createValidator) : base(uow, mapper, createValidator)
        {
        }
    }
}
