using CoreDomainFeature.ShippingSoloEntity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersistenceFeature.ShippingSoloEntity
{
  public class ShippingSoloConfigRule : IEntityTypeConfiguration<ShippingSolo>
  {
    public void Configure(EntityTypeBuilder<ShippingSolo> entity)
    {
      entity.HasKey(i => i.Id);
      entity.Property(i => i.RegionNumber).IsRequired();
      entity.Property(i => i.PostageCost).IsRequired().HasColumnType("Money");
    }
  }
}
