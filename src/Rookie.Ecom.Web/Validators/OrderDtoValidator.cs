using FluentValidation;
using Rookie.Ecom.Contracts.Constants;
using Rookie.Ecom.Contracts.Dtos;

namespace Rookie.Ecom.Web.Validators
{
    public class OrderDtoValidator : BaseValidator<OrderDto>
    {
        public OrderDtoValidator()
        {
            RuleFor(m => m.Id)
                 .NotNull()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Id)));

            RuleFor(m => m.User)
                  .NotEmpty()
                  .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.User)));
            RuleFor(m => m.OrderName)
                 .NotEmpty()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.OrderName)));
            RuleFor(m => m.Quantity)
                 .NotEmpty()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Quantity)));
            RuleFor(m => m.Price)
                 .NotEmpty()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Price)));

            RuleFor(m => m.OrderName)
               .MaximumLength(ValidationRules.OrderRules.MinLenghCharactersForOrderName)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.OrderRules.MinLenghCharactersForOrderName))
               .When(m => !string.IsNullOrWhiteSpace(m.OrderName));

           
        }
    }
}
