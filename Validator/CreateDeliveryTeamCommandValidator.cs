using FluentValidation;
using Command;
namespace Validator
{
  public class CreateDeliveryTeamCommandValidator : AbstractValidator<CreateDeliveryTeamCommand>
  {
    public CreateDeliveryTeamCommandValidator()
    {
      RuleFor(p => p.Description).NotEmpty().WithMessage("Description required");
    }
  }
}