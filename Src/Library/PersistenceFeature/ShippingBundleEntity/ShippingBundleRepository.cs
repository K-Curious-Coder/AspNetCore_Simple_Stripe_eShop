using System.Threading.Tasks;

using CoreDomainFeature.ShippingBundleEntity;

using Microsoft.EntityFrameworkCore;

using PersistenceFeature.Repository;

namespace PersistenceFeature.ShippingBundleEntity
{
  public class ShippingBundleRepository : ReaderRepository<ShippingBundle>, IShippingBundleRepository
  {
    public ShippingBundleRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<decimal> GetShippingCostFromDataSourceBundleAsync(int shippingRegionID) => (await this.GetApplicationDbContext().ShippingBundle.AsNoTracking().FirstOrDefaultAsync(item => item.RegionNumber == shippingRegionID)).PostageCost;
  }
}
