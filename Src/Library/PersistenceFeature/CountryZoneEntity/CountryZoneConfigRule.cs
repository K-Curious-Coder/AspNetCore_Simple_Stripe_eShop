using CoreDomainFeature.CountryZoneEntity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersistenceFeature.CountryZoneEntity
{
  public class CountryZoneConfigRule : IEntityTypeConfiguration<CountryZone>
  {
    public void Configure(EntityTypeBuilder<CountryZone> entity)
    {
      entity.HasKey(i => i.Id);
      entity.Property(i => i.CountryZoneName).IsRequired();
    }
  }
}
