using MediatR;
using Util;
using ViewModel;
namespace Command
{
  public class CreateDeliveryTeamCommand : IRequest<RequestResult<CreateDeliveryTeamViewModel>>
  {
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
  }
}