using FluentValidation;
using Rookie.Ecom.Contracts.Constants;
using Rookie.Ecom.Contracts.Dtos;

namespace Rookie.Ecom.Web.Validators
{
    public class UserDtoValidator : BaseValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(m => m.Id)
                 .NotNull()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Id)));

            RuleFor(m => m.FirstName)
                  .NotEmpty()
                  .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.FirstName)));
            RuleFor(m => m.LastName)
                 .NotEmpty()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.LastName)));
            RuleFor(m => m.Email)
                 .NotEmpty()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Email)));
            RuleFor(m => m.Age)
                 .NotEmpty()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Address)));
            RuleFor(m => m.Address)
                 .NotEmpty()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Address)));
            RuleFor(m => m.Username)
                 .NotEmpty()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Username)));
            RuleFor(m => m.Password)
               .NotEmpty()
               .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Password)));
            RuleFor(m => m.Gender)
               .NotEmpty()
               .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Gender)));



            RuleFor(m => m.FirstName)
               .MaximumLength(ValidationRules.UserRules.MinLenghCharactersForFirstName)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.UserRules.MinLenghCharactersForFirstName))
               .When(m => !string.IsNullOrWhiteSpace(m.FirstName));

            RuleFor(m => m.LastName)
               .MaximumLength(ValidationRules.UserRules.MinLenghCharactersForLastName)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.UserRules.MinLenghCharactersForLastName))
               .When(m => !string.IsNullOrWhiteSpace(m.LastName));

            RuleFor(m => m.LastName)
             .MaximumLength(ValidationRules.UserRules.MinLenghCharactersForEmail)
             .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.UserRules.MinLenghCharactersForEmail))
             .When(m => !string.IsNullOrWhiteSpace(m.Email));
        }
    }
}
