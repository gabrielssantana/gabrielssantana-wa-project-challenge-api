using FluentValidation;
using Command;
namespace Validator
{
  public class CreateDeliveryTeamCommandValidator : AbstractValidator<CreateDeliveryTeamCommand>
  {
    public CreateDeliveryTeamCommandValidator()
    {
      RuleFor(p => p.Description).NotEmpty().WithMessage("Description required");
      RuleFor(p => p.Name).NotEmpty().WithMessage("Name required");
      RuleFor(p => p.Plate).NotEmpty().WithMessage("Plate required");
    }
  }
}