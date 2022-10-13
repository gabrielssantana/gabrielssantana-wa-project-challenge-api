using Command;
using FluentValidation;

namespace Validator
{
  public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
  {
    public CreateProductCommandValidator()
    {

    }
  }
}