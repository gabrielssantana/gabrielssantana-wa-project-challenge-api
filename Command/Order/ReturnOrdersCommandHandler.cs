using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class ReturnOrdersCommandHandler : IRequestHandler<ReturnOrdersCommand, PagedBaseRequestResult<ReturnOrderViewModel>>
  {
    public Task<PagedBaseRequestResult<ReturnOrderViewModel>> Handle(ReturnOrdersCommand request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}