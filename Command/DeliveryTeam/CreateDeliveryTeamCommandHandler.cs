using AutoMapper;
using Interface;
using MediatR;
using Util;
using Validator;
using ViewModel;

namespace Command
{
  public class CreateDeliveryTeamCommandHandler : IRequestHandler<CreateDeliveryTeamCommand, RequestResult<CreateDeliveryTeamViewModel>>
  {
    private readonly IDeliveryTeamRepository _deliveryTeamRepository;
    private readonly IMapper _mapper;
    private readonly CreateDeliveryTeamCommandValidator _commandValidator = new();
    public CreateDeliveryTeamCommandHandler(
      IDeliveryTeamRepository deliveryTeamRepository,
      IMapper mapper
    )
    {
      _deliveryTeamRepository = deliveryTeamRepository ?? throw new ArgumentNullException(nameof(deliveryTeamRepository));
      _mapper = mapper;
    }
    public async Task<RequestResult<CreateDeliveryTeamViewModel>> Handle(CreateDeliveryTeamCommand request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}