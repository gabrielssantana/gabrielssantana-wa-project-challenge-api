using Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
  [ApiController]
  [Route("delivery")]
  public class DeliveryTeamController : ControllerBase
  {
    private readonly IMediator _mediator;
    public DeliveryTeamController(
      IMediator mediator
    )
    {
      _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }
    [HttpPost]
    public async Task<IActionResult> CreateDeliveryTeam(
      CreateDeliveryTeamCommand command
    )
    {
      try
      {
        var result = await _mediator.Send(command);
        return StatusCode(result.StatusCode, result.Data);
      }
      catch (Exception e)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, e);
      }
    }
  }
}