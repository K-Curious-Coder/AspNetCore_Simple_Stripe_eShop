using System.Threading.Tasks;

using CoreDomainFeature.ShippingSoloEntity;

using Microsoft.EntityFrameworkCore;
using PersistenceFeature.Repository;

namespace PersistenceFeature.ShippingSoloEntity
{
  public class ShippingSoloRepository : ReaderRepository<ShippingSolo>, IShippingSoloRepository
  {
    public ShippingSoloRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<decimal> GetShippingCostFromDataSourceSoloAsync(int shippingRegionID) => (await this.GetApplicationDbContext().ShippingSolo.AsNoTracking().FirstOrDefaultAsync(item => item.RegionNumber == shippingRegionID)).PostageCost;
  }
}
