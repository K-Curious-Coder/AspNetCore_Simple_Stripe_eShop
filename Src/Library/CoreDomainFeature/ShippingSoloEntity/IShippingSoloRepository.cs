using System.Threading.Tasks;
using CoreFeature.BaseDataServices;

namespace CoreDomainFeature.ShippingSoloEntity
{
  public interface IShippingSoloRepository : IReaderRepository<ShippingSolo>
  {
    Task<decimal> GetShippingCostFromDataSourceSoloAsync(int shippingRegionID);
  }
}
