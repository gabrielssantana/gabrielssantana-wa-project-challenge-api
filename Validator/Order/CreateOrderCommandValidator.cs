using Command;
using FluentValidation;

namespace Validator
{
  public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
  {
    public CreateOrderCommandValidator()
    {
      RuleFor(p => p.Address).NotEmpty().WithMessage("Address required");
      RuleFor(p => p.ProductsIds).NotEmpty().WithMessage("Order needs at least one product");
    }
  }
}