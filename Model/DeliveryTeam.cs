using System.ComponentModel.DataAnnotations;

namespace Model
{
  public class DeliveryTeam
  {
    [Key]
    public int IdDeliveryTeam { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Plate { get; set; } = string.Empty;
    // References
    public ICollection<Order> Orders { get; set; }
    public DeliveryTeam(
      string name,
      string description,
      string plate
    )
    {
      Name = name;
      Description = description;
      Plate = plate;
    }
    protected DeliveryTeam() { }
  }
}