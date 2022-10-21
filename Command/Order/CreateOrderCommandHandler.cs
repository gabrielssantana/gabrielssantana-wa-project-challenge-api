using AutoMapper;
using Interface;
using MediatR;
using Model;
using Util;
using Validator;
using ViewModel;

namespace Command
{
  public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, RequestResult<CreateOrderViewModel>>
  {
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;
    private readonly CreateOrderCommandValidator _commandValidator = new();
    public CreateOrderCommandHandler(
      IOrderRepository orderRepository,
      IMapper mapper
    )
    {
      _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
      _mapper = mapper;
    }
    public async Task<RequestResult<CreateOrderViewModel>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
      var result = new RequestResult<CreateOrderViewModel>();
      var commandValidation = await _commandValidator.ValidateAsync(request).ConfigureAwait(false);
      if (!commandValidation.IsValid)
      {
        result.BadRequest(commandValidation.Errors);
        return result;
      }
      var order = new Order(
        address: request.Address
      );
      _orderRepository.Add(order);
      var saved = await _orderRepository.UnitOfWork.Commit();
      if (!saved)
      {
        result.BadRequest("Can't save order");
        return result;
      }
      var aux = _mapper.Map<CreateOrderViewModel>(order);
      result.Created(aux);
      return result;
    }
  }
}