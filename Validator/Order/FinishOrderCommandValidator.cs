using Command;
using FluentValidation;

namespace Validator
{
  public class FinishOrderCommandValidator : AbstractValidator<FinishOrderCommand>
  {
    public FinishOrderCommandValidator()
    {
      RuleFor(p => p.OrderId).NotEmpty().WithMessage("OrderId required");
    }
  }
}