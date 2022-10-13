using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Mapping
{
  public class OrderMapping : IEntityTypeConfiguration<Order>
  {
    public void Configure(EntityTypeBuilder<Order> builder)
    {
      builder
      .HasKey(e => e.IdOrder)
      .HasName("PK_Order");

      builder
      .ToTable("Order");

      builder
      .Property(e => e.IdOrder)
      .HasColumnName("IDOrder")
      .ValueGeneratedOnAdd()
      .UseIdentityColumn();

      builder
      .Property(e => e.CreatedAt)
      .IsRequired()
      .IsUnicode(false)
      .HasColumnType("timestamp");

      builder
      .Property(e => e.DeliveredAt)
      .IsRequired(false)
      .IsUnicode(false)
      .HasColumnType("timestamp");

      builder
      .Property(e => e.Address)
      .IsRequired()
      .IsUnicode(false);

      builder
      .Property(e => e.DeliveryTeamId)
      .IsRequired();

      builder
      .HasOne(e => e.DeliveryTeam)
      .WithMany(e => e.Orders)
      .HasForeignKey(e => e.DeliveryTeamId);

      builder
      .HasMany(e => e.OrderProducts)
      .WithOne(e => e.Order)
      .HasForeignKey(e => e.OrderId);

    }
  }
}