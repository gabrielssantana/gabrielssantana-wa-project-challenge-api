using Data;
using Interface;
using Model;

namespace Repository
{
  public class OrderRepository : Repository<Order>, IOrderRepository
  {
    public OrderRepository(AppDbContext dbContext) : base(dbContext)
    {

    }
  }
}