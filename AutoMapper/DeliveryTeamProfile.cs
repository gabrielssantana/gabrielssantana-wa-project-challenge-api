using Model;
using ViewModel;

namespace AutoMapper
{
  public class DeliveryTeamProfile : Profile
  {
    public DeliveryTeamProfile()
    {
      CreateMap<DeliveryTeam, CreateDeliveryTeamViewModel>().ReverseMap();
    }
  }
}