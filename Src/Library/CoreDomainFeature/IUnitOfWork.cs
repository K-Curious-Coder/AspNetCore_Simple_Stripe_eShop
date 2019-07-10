using System.Threading.Tasks;
using CoreDomainFeature.CountryEntity;
using CoreDomainFeature.CountryZoneEntity;
using CoreDomainFeature.ProductEntity;
using CoreDomainFeature.ShippingBundleEntity;
using CoreDomainFeature.ShippingCosyEntity;
using CoreDomainFeature.ShippingSoloEntity;

namespace CoreDomainFeature
{
  public interface IUnitOfWork
  {
    IProductRepository ProductRepository { get; }

    ICountryRepository CountryRepository { get; }
    ICountryZoneRepository CountryZoneRepository { get; }

    IShippingSoloRepository ShippingSoloRepository { get; }
    IShippingBundleRepository ShippingBundleRepository { get; }
    IShippingCosyRepository ShippingCosyRepository { get; }

    Task SaveChangesAsync();
  }
}
