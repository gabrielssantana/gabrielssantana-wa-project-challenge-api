using Command;
using FluentValidation;

namespace Validator
{
  public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
  {
    public CreateOrderCommandValidator()
    {

    }
  }
}