using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Mapping
{
  public class ProductMapping : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
      builder
      .HasKey(e => e.IdProduct)
      .HasName("PK_product");

      builder
      .ToTable("Product");

      builder
      .Property(e => e.IdProduct)
      .HasColumnName("IDProduct")
      .ValueGeneratedOnAdd()
      .UseIdentityColumn();

      builder
      .Property(e => e.Name)
      .IsRequired()
      .IsUnicode(false);

      builder
      .Property(e => e.Description)
      .IsRequired()
      .IsUnicode(false);

      builder
      .Property(e => e.Value)
      .IsRequired();

      builder
      .HasMany(e => e.OrderProducts)
      .WithOne(e => e.Product)
      .HasForeignKey(e => e.ProductId);

    }
  }
}