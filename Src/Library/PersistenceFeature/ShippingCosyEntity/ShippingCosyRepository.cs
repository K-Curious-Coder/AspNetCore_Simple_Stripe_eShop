using System.Threading.Tasks;

using CoreDomainFeature.ShippingCosyEntity;

using Microsoft.EntityFrameworkCore;
using PersistenceFeature.Repository;

namespace PersistenceFeature.ShippingCosyEntity
{
  public class ShippingCosyRepository : ReaderRepository<ShippingCosy>, IShippingCosyRepository
  {
    public ShippingCosyRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<decimal> GetShippingCostFromDataSourceCosyAsync(int shippingRegionID) => (await this.GetApplicationDbContext().ShippingCosy.AsNoTracking().FirstOrDefaultAsync(item => item.RegionNumber == shippingRegionID)).PostageCost;
  }
}
