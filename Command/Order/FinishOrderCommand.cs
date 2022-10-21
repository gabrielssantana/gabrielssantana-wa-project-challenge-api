using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class FinishOrderCommand : IRequest<RequestResult<FinishOrderViewModel>>
  {
    public int OrderId { get; set; }
  }
}