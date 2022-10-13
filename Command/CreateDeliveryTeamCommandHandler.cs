using MediatR;
using Util;
using ViewModel;

namespace Command
{
  public class CreateDeliveryTeamCommandHandler : IRequestHandler<CreateDeliveryTeamCommand, RequestResult<CreateDeliveryTeamViewModel>>
  {
    public async Task<RequestResult<CreateDeliveryTeamViewModel>> Handle(CreateDeliveryTeamCommand request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}