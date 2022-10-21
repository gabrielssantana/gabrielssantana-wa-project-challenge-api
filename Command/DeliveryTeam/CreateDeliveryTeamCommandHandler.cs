using AutoMapper;
using Interface;
using MediatR;
using Model;
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
      var result = new RequestResult<CreateDeliveryTeamViewModel>();
      var commandValidation = await _commandValidator.ValidateAsync(request).ConfigureAwait(false);
      if (!commandValidation.IsValid)
      {
        result.BadRequest(commandValidation.Errors);
        return result;
      }
      var deliveryTeam = new DeliveryTeam(
        name: request.Name,
        description: request.Description,
        plate: request.Plate
      );
      _deliveryTeamRepository.Add(deliveryTeam);
      var saved = await _deliveryTeamRepository.UnitOfWork.Commit();
      if (!saved)
      {
        result.BadRequest("Can't save delivery team");
        return result;
      }
      var aux = _mapper.Map<CreateDeliveryTeamViewModel>(deliveryTeam);
      result.Created(aux);
      return result;
    }
  }
}