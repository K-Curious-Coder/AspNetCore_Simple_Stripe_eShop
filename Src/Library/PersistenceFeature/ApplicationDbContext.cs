using CoreDomainFeature.CountryEntity;
using CoreDomainFeature.CountryZoneEntity;
using CoreDomainFeature.ProductEntity;
using CoreDomainFeature.ShippingBundleEntity;
using CoreDomainFeature.ShippingCosyEntity;
using CoreDomainFeature.ShippingSoloEntity;

using Microsoft.EntityFrameworkCore;

using PersistenceFeature.CountryEntity;
using PersistenceFeature.CountryZoneEntity;
using PersistenceFeature.ProductEntity;
using PersistenceFeature.ShippingBundleEntity;
using PersistenceFeature.ShippingCosyEntity;
using PersistenceFeature.ShippingSoloEntity;

namespace PersistenceFeature
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<ShippingSolo> ShippingSolo { get; set; }
    public DbSet<ShippingBundle> ShippingBundle { get; set; }
    public DbSet<ShippingCosy> ShippingCosy { get; set; }

    public DbSet<CountryZone> CountryZone { get; set; }
    public DbSet<Country> Country { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) => this.Database.Migrate();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new CountryZoneConfigRule());
      modelBuilder.ApplyConfiguration(new CountryConfigRule());

      modelBuilder.ApplyConfiguration(new ProductConfigRule());

      modelBuilder.ApplyConfiguration(new ShippingSoloConfigRule());
      modelBuilder.ApplyConfiguration(new ShippingBundleConfigRule());
      modelBuilder.ApplyConfiguration(new ShippingCosyConfigRule());

#if DEBUG
      modelBuilder.CreateProduct();

      modelBuilder.CreateShippingSolo();

      modelBuilder.CreateShippingBundle();

      modelBuilder.CreateShippingCosy();

      modelBuilder.CreateCountryRegion();

      modelBuilder.CreateCountry();
#endif

      base.OnModelCreating(modelBuilder);
    }
  }
}
