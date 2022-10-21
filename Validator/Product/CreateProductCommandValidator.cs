using Command;
using FluentValidation;

namespace Validator
{
  public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
  {
    public CreateProductCommandValidator()
    {
      RuleFor(p => p.Description).NotEmpty().WithMessage("Description required");
      RuleFor(p => p.Name).NotEmpty().WithMessage("Name required");
      RuleFor(p => p.Value).NotEmpty().WithMessage("Value required and can't be zero.");
    }
  }
}