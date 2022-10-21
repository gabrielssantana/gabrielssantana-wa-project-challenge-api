using Data;
using Interface;
using Model;

namespace Repository
{
  public class DeliveryTeamRepository : Repository<DeliveryTeam>, IDeliveryTeamRepository
  {
    public DeliveryTeamRepository(AppDbContext dbContext) : base(dbContext)
    {

    }
  }
}