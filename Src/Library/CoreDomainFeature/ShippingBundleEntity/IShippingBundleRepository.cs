using System.Threading.Tasks;

using CoreFeature.BaseDataServices;

namespace CoreDomainFeature.ShippingBundleEntity
{
  public interface IShippingBundleRepository : IReaderRepository<ShippingBundle>
  {
    Task<decimal> GetShippingCostFromDataSourceBundleAsync(int shippingRegionID);
  }
}
