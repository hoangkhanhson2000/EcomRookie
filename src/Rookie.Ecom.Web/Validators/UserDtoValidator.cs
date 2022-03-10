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
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Age)));
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
               .MaximumLength(ValidationRules.UserRules.MaxLenghCharactersForFirstName)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.UserRules.MaxLenghCharactersForFirstName))
               .When(m => !string.IsNullOrWhiteSpace(m.FirstName));

            RuleFor(m => m.LastName)
               .MaximumLength(ValidationRules.UserRules.MaxLenghCharactersForLastName)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.UserRules.MaxLenghCharactersForLastName))
               .When(m => !string.IsNullOrWhiteSpace(m.LastName));

            RuleFor(m => m.LastName)
             .MaximumLength(ValidationRules.UserRules.MaxLenghCharactersForEmail)
             .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.UserRules.MaxLenghCharactersForEmail))
             .When(m => !string.IsNullOrWhiteSpace(m.Email));
        }
    }
}
