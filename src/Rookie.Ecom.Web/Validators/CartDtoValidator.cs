using FluentValidation;
using Rookie.Ecom.Contracts.Constants;
using Rookie.Ecom.Contracts.Dtos;

namespace Rookie.Ecom.Web.Validators
{
    public class CartDtoValidator : BaseValidator<CartDto>
    {
        public CartDtoValidator()
        {
            RuleFor(m => m.Id)
                 .NotNull()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Id)));

            RuleFor(m => m.CartName)
                  .NotEmpty()
                  .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.CartName)));
            RuleFor(m => m.CartItem)
            .NotEmpty()
            .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.CartItem)));

            RuleFor(m => m.CartName)
               .MaximumLength(ValidationRules.CartRules.MaxLenghCharactersForCart)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.CartRules.MaxLenghCharactersForCart))
               .When(m => !string.IsNullOrWhiteSpace(m.CartName));

        }
    }
}
