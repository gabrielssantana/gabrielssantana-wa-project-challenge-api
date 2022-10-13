namespace ViewModel
{
  public class CreateOrderViewModel
  {
    public int IdOrder { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DeliveredAt { get; set; }
    public string Address { get; set; } = string.Empty;
    public int DeliveryTeamId { get; set; }
  }
}