using AutoMapper;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Common.Interfaces;
using MSS_NewsWeb.Data.Interfaces;
using MSS_NewsWeb.Services;
using FluentValidation;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Bussines.Services
{
    public class CategoryService : Service<CategoryCreateDto, CategoryListDto, CategoryUpdateDto, Category>, ICategoryService
    {
        public CategoryService(IUow uow, IMapper mapper, IValidator<CategoryCreateDto> createValidator) : base(uow, mapper, createValidator)
        {
        }
    }
}
