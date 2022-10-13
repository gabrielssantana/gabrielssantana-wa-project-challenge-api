using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, RequestResult<CreateProductViewModel>>
  {
    public async Task<RequestResult<CreateProductViewModel>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}