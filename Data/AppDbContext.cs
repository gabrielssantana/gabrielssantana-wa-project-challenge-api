using Interface;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
  public class AppDbContext : DbContext, IUnitOfWork
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Order> Order { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<OrderProduct> OrderProduct { get; set; }
    public DbSet<DeliveryTeam> DeliveryTeam { get; set; }
    public async Task<bool> Commit()
    {
      return await SaveChangesAsync() > 0;
    }
  }
}