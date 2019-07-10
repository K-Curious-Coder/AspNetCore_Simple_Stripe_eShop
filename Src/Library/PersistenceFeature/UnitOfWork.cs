using System.Threading.Tasks;

using CoreDomainFeature;
using CoreDomainFeature.CountryEntity;
using CoreDomainFeature.CountryZoneEntity;
using CoreDomainFeature.ProductEntity;
using CoreDomainFeature.ShippingBundleEntity;
using CoreDomainFeature.ShippingCosyEntity;
using CoreDomainFeature.ShippingSoloEntity;

// Remember IDisposable!

namespace PersistenceFeature
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly ApplicationDbContext applicationDbContext;

    public UnitOfWork
    (ApplicationDbContext applicationDbContext,
     IProductRepository productRepository,
     ICountryRepository countryRepository,
     ICountryZoneRepository countryZoneRepository,
     IShippingSoloRepository shippingSoloRepository,
     IShippingBundleRepository shippingBundleRepository,
     IShippingCosyRepository shippingCosyRepository)
    {
      this.applicationDbContext = applicationDbContext;
      this.ProductRepository = productRepository;
      this.CountryRepository = countryRepository;
      this.CountryZoneRepository = countryZoneRepository;
      this.ShippingSoloRepository = shippingSoloRepository;
      this.ShippingBundleRepository = shippingBundleRepository;
      this.ShippingCosyRepository = shippingCosyRepository;
    }

    public IProductRepository ProductRepository { get; }

    public ICountryRepository CountryRepository { get; }

    public ICountryZoneRepository CountryZoneRepository { get; }

    public IShippingSoloRepository ShippingSoloRepository { get; }

    public IShippingBundleRepository ShippingBundleRepository { get; }

    public IShippingCosyRepository ShippingCosyRepository { get; }

    public async Task SaveChangesAsync() => await this.applicationDbContext.SaveChangesAsync(); // To Test!...
  }
}
