using Model;
using ViewModel;

namespace AutoMapper
{
  public class OrderProfile : Profile
  {
    public OrderProfile()
    {
      CreateMap<Order, CreateOrderViewModel>().ReverseMap();
      CreateMap<Order, FinishOrderViewModel>().ReverseMap();
      CreateMap<Order, CreateOrderViewModel>().ReverseMap();
    }
  }
}