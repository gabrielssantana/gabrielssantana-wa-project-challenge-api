using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class CreateOrderCommand : IRequest<RequestResult<CreateOrderViewModel>>
  {
    public string Address { get; set; } = string.Empty;
    public List<int> ProductsIds { get; set; }
  }
}