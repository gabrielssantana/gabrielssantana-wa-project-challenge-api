using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class FinishOrderCommandHandler : IRequestHandler<FinishOrderCommand, RequestResult<FinishOrderViewModel>>
  {
    public Task<RequestResult<FinishOrderViewModel>> Handle(FinishOrderCommand request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}