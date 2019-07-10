using CoreDomainFeature.ShippingCosyEntity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersistenceFeature.ShippingCosyEntity
{
  public class ShippingCosyConfigRule : IEntityTypeConfiguration<ShippingCosy>
  {
    public void Configure(EntityTypeBuilder<ShippingCosy> entity)
    {
      entity.HasKey(i => i.Id);
      entity.Property(i => i.RegionNumber).IsRequired();
      entity.Property(i => i.PostageCost).IsRequired().HasColumnType("Money");
    }
  }
}
