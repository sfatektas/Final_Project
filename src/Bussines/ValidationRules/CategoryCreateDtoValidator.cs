using MSS_NewsWeb.Bussines.Dtos;
using FluentValidation;

namespace MSS_NewsWeb.Bussines.ValidationRules
{
    public class CategoryCreateDtoValidator : AbstractValidator<CategoryCreateDto>
    {
        public CategoryCreateDtoValidator()
        {
            RuleFor(x => x.Defination).NotNull();
        }
    }
}
