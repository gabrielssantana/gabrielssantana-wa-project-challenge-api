using Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
  [ApiController]
  [Route("product")]
  public class ProductController : ControllerBase
  {
    private readonly IMediator _mediator;
    public ProductController(
      IMediator mediator
    )
    {
      _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }
    [HttpPost]
    public async Task<IActionResult> CreateProduct(
      CreateProductCommand command
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