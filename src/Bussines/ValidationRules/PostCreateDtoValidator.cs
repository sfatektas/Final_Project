using MSS_NewsWeb.Bussines.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace MSS_NewsWeb.Bussines.ValidationRules
{
    public class PostCreateDtoValidator : AbstractValidator<PostCreateDto>
    {
        public PostCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.Defination1).NotNull();
            RuleFor(x => x.AppUserId).NotNull();
            RuleFor(x => x.CategoryId).NotNull();
        }
    }

}
