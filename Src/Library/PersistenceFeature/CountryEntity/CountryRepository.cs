using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CoreDomainFeature.CountryEntity;

using Microsoft.EntityFrameworkCore;

using PersistenceFeature.Repository;

namespace PersistenceFeature.CountryEntity
{
  public class CountryRepository : ReaderRepository<Country>, ICountryRepository
  {
    public CountryRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IList<Country>> GetAllCountriesAsync() => await this.GetApplicationDbContext().Country.AsNoTracking().ToListAsync();

    public async Task<IList<Country>> GetAllCountriesByCountryZoneIdAsync(int countryZoneId) => await this.GetApplicationDbContext().Country.Where(c => c.CountryZoneId == countryZoneId).AsNoTracking().ToListAsync();
  }
}
