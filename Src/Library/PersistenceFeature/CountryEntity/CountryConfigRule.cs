using CoreDomainFeature.CountryEntity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersistenceFeature.CountryEntity
{
  public class CountryConfigRule : IEntityTypeConfiguration<Country>
  {
    public void Configure(EntityTypeBuilder<Country> entity)
    {
      entity.HasKey(i => i.Id);
      entity.Property(i => i.CountryName).IsRequired();
    }
  }
}
