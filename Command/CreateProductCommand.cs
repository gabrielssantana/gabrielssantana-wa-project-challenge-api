using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class CreateProductCommand : IRequest<RequestResult<CreateProductViewModel>>
  {
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Value { get; set; }
  }
}