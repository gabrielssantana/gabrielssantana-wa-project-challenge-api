using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, RequestResult<CreateOrderViewModel>>
  {
    public Task<RequestResult<CreateOrderViewModel>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}