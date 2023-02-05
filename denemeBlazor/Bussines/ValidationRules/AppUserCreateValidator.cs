using MSS_NewsWeb.Bussines.Dtos;
using FluentValidation;

namespace MSS_NewsWeb.Bussines.ValidationRules
{
    public class AppUserCreateDtoValidator : AbstractValidator<AppUserCreateDto>
    {
        public AppUserCreateDtoValidator()
        {
            RuleFor(x => x.Username).NotNull();
            RuleFor(x=> x.AppRoleId).NotEmpty();
            RuleFor(x=> x.FirstName).NotEmpty().MinimumLength(4);
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x=>x.Password).NotEmpty();
        }
    }
}
