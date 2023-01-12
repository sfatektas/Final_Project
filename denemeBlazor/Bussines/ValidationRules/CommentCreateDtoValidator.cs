using denemeBlazor.Bussines.Dtos;
using FluentValidation;

namespace denemeBlazor.Bussines.ValidationRules
{
    public class CommentCreateDtoValidator : AbstractValidator<CommentCreateDto>
    {
        public CommentCreateDtoValidator()
        {
            RuleFor(x => x.Content_).NotNull();
            RuleFor(x => x.PostId).NotNull();
            RuleFor(x => x.AppUserId).NotNull();
        }
    }
}
