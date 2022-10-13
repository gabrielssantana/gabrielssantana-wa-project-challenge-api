using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Order> Order { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<OrderProduct> OrderProduct { get; set; }
    public DbSet<DeliveryTeam> DeliveryTeam { get; set; }
  }
}