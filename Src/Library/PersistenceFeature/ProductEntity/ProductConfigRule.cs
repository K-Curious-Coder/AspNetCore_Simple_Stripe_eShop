using CoreDomainFeature.ProductEntity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PersistenceFeature.ProductEntity
{
  public class ProductConfigRule : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> entity)
    {
      entity.HasKey(i => i.Id);
      entity.Property(i => i.CurrentProductId).IsRequired();
      entity.Property(i => i.ProductName).IsRequired();
      entity.Property(i => i.ProductDescription).IsRequired();
      entity.Property(i => i.ProductPrice).IsRequired().HasColumnType("Money");
    }
  }
}
