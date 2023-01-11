using denemeBlazor.Bussines.Dtos;
using FluentValidation;

namespace denemeBlazor.Bussines.ValidationRules
{
    public class CategoryCreateDtoValidator : AbstractValidator<CategoryCreateDto>
    {
        public CategoryCreateDtoValidator()
        {
            RuleFor(x => x.Defination).NotNull();
        }
    }
}
