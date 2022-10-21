using Command;
using FluentValidation;

namespace Validator
{
  public class ReturnOrdersCommandValidator : AbstractValidator<ReturnOrdersCommand>
  {
    public ReturnOrdersCommandValidator()
    {
      RuleFor(p => p.OrderByProperty).NotEmpty().WithMessage("OrderByProperty required");
      RuleFor(p => p.Page).NotNull().WithMessage("Page can't be null");
      RuleFor(p => p.PageSize).NotEmpty().WithMessage("PageSize required and can't be zero");
    }
  }
}