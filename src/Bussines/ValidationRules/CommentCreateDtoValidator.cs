using MSS_NewsWeb.Bussines.Dtos;
using FluentValidation;

namespace MSS_NewsWeb.Bussines.ValidationRules
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
