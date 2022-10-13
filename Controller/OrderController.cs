using Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
  [ApiController]
  [Route("order")]
  public class OrderController : ControllerBase
  {
    private readonly IMediator _mediator;
    public OrderController(
      IMediator mediator
    )
    {
      _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }
    [HttpPost]
    public async Task<IActionResult> CreateOrder(
      CreateOrderCommand command
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
    [HttpPost]
    [Route("finish")]
    public async Task<IActionResult> FinishOrder(
      FinishOrderCommand command
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
    [HttpGet]
    public async Task<IActionResult> ReturnOrders(
      [FromQuery] ReturnOrdersCommand command
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