using AutoMapper;
using Interface;
using MediatR;
using Model;
using Util;
using Validator;
using ViewModel;

namespace Command
{
  public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, RequestResult<CreateProductViewModel>>
  {
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    private readonly CreateProductCommandValidator _commandValidator = new();
    public CreateProductCommandHandler(
      IProductRepository productRepository,
      IMapper mapper
    )
    {
      _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
      _mapper = mapper;
    }
    public async Task<RequestResult<CreateProductViewModel>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
      var result = new RequestResult<CreateProductViewModel>();
      var commandValidation = await _commandValidator.ValidateAsync(request).ConfigureAwait(false);
      if (!commandValidation.IsValid)
      {
        result.BadRequest(commandValidation.Errors);
        return result;
      }
      var product = new Product(
        name: request.Name,
        description: request.Description,
        value: request.Value
      );
      _productRepository.Add(product);
      var saved = await _productRepository.UnitOfWork.Commit();
      if (!saved)
      {
        result.BadRequest("Can't save product");
        return result;
      }
      var aux = _mapper.Map<CreateProductViewModel>(product);
      result.Created(aux);
      return result;
    }
  }
}