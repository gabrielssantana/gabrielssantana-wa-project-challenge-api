using System.ComponentModel.DataAnnotations;

namespace Model
{
  public class Order
  {
    [Key]
    public int IdOrder { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? DeliveredAt { get; set; }
    public string Address { get; set; } = string.Empty;
    public int DeliveryTeamId { get; set; }
    // References
    public ICollection<Product> Products { get; set; }
    public ICollection<OrderProduct> OrderProducts { get; set; }
    public DeliveryTeam DeliveryTeam { get; set; }
    public Order(
      string address
    )
    {
      Address = address;
    }
    protected Order() { }
    public Order FinishOrder(DateTime deliveredAt)
    {
      DeliveredAt = deliveredAt;
      return this;
    }
  }
}