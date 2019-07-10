using CoreDomainFeature.ShippingBundleEntity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersistenceFeature.ShippingBundleEntity
{
  public class ShippingBundleConfigRule : IEntityTypeConfiguration<ShippingBundle>
  {
    public void Configure(EntityTypeBuilder<ShippingBundle> entity)
    {
      entity.HasKey(i => i.Id);
      entity.Property(i => i.RegionNumber).IsRequired();
      entity.Property(i => i.PostageCost).IsRequired().HasColumnType("Money");
    }
  }
}
