using Model;
using ViewModel;

namespace AutoMapper
{
  public class ProductProfile : Profile
  {
    public ProductProfile()
    {
      CreateMap<Product, CreateProductViewModel>().ReverseMap();
      CreateMap<Product, ReturnProductViewModel>().ReverseMap();
    }
  }
}