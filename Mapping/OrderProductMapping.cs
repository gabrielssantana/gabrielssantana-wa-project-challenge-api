using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Mapping
{
  public class OrderProductMapping : IEntityTypeConfiguration<OrderProduct>
  {
    public void Configure(EntityTypeBuilder<OrderProduct> builder)
    {
      builder
      .HasKey(e => e.IdOrderProduct)
      .HasName("PK_OrderProduct");

      builder
      .ToTable("OrderProduct");

      builder
      .Property(e => e.IdOrderProduct)
      .HasColumnName("IDOrderProduct")
      .ValueGeneratedOnAdd()
      .UseIdentityColumn();

      builder
      .Property(e => e.OrderId)
      .HasColumnName("OrderID")
      .IsRequired();

      builder
      .Property(e => e.ProductId)
      .HasColumnName("ProductID")
      .IsRequired();

      builder
      .HasOne(e => e.Order)
      .WithMany(e => e.OrderProducts)
      .HasForeignKey(e => e.OrderId);

      builder
      .HasOne(e => e.Product)
      .WithMany(e => e.OrderProducts)
      .HasForeignKey(e => e.ProductId);
    }
  }
}