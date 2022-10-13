namespace ViewModel
{
  public class CreateProductViewModel
  {
    public int IdProduct { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Value { get; set; }
  }
}