using System.ComponentModel.DataAnnotations;

namespace Model
{
  public class OrderProduct
  {
    [Key]
    public int IdOrderProduct { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    // References
    public Order Order { get; set; }
    public Product Product { get; set; }
    public OrderProduct(
      int orderId,
      int productId
    )
    {
      OrderId = orderId;
      ProductId = productId;
    }
    protected OrderProduct() { }
  }
}