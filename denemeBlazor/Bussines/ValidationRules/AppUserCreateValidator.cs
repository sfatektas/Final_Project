using denemeBlazor.Bussines.Dtos;
using FluentValidation;

namespace denemeBlazor.Bussines.ValidationRules
{
    public class AppUserCreateDtoValidator : AbstractValidator<AppUserCreateDto>
    {
        public AppUserCreateDtoValidator()
        {
            RuleFor(x => x.Username).NotNull();
            RuleFor(x=> x.AppRoleId).NotEmpty();
            RuleFor(x=> x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x=>x.Password).NotEmpty();
        }
    }
}
