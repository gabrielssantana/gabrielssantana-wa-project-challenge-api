using Data;
using Interface;
using Model;

namespace Repository
{
  public class ProductRepository : Repository<Product>, IProductRepository
  {
    public ProductRepository(AppDbContext dbContext) : base(dbContext)
    {

    }
  }
}