using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class ReturnOrdersCommand : PagedBaseRequest, IRequest<PagedBaseRequestResult<ReturnOrderViewModel>>
  {
    public override string OrderByProperty { get; set; } = "CreatedAt";
  }
}