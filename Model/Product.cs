using System.ComponentModel.DataAnnotations;

namespace Model
{
  public class Product
  {
    [Key]
    public int IdProduct { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Value { get; set; }
    // References
    public ICollection<Order> Orders { get; set; }
    public ICollection<OrderProduct> OrderProducts { get; set; }
    public Product(
      string name,
      string description,
      decimal value
    )
    {
      Name = name;
      Description = description;
      Value = value;
    }
    protected Product() { }
  }
}