using System.Collections.Generic;
using System.Threading.Tasks;

using CoreDomainFeature.CountryZoneEntity;

using Microsoft.EntityFrameworkCore;

using PersistenceFeature.Repository;

namespace PersistenceFeature.CountryZoneEntity
{
  public class CountryZoneRepository : ReaderRepository<CountryZone>, ICountryZoneRepository
  {
    public CountryZoneRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IList<CountryZone>> GetAllCountryZonesAsync() => await this.GetApplicationDbContext().CountryZone.AsNoTracking().ToListAsync();
  }
}
