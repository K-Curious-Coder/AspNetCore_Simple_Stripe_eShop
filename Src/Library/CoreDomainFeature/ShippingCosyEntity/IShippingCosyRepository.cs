using System.Threading.Tasks;

using CoreFeature.BaseDataServices;

namespace CoreDomainFeature.ShippingCosyEntity
{
  public interface IShippingCosyRepository : IReaderRepository<ShippingCosy>
  {
    Task<decimal> GetShippingCostFromDataSourceCosyAsync(int shippingRegionID);
  }
}
