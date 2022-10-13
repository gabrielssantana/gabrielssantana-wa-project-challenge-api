using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Mapping
{
  public class DeliveryTeamMapping : IEntityTypeConfiguration<DeliveryTeam>
  {
    public void Configure(EntityTypeBuilder<DeliveryTeam> builder)
    {
      builder
      .HasKey(e => e.IdDeliveryTeam)
      .HasName("PK_DeliveryTeam");

      builder
      .ToTable("DeliveryTeam");

      builder
      .Property(e => e.IdDeliveryTeam)
      .HasColumnName("IDDeliveryTeam")
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
      .Property(e => e.Plate)
      .IsRequired()
      .IsUnicode(false);

      builder
      .HasMany(e => e.Orders)
      .WithOne(e => e.DeliveryTeam);

    }
  }
}