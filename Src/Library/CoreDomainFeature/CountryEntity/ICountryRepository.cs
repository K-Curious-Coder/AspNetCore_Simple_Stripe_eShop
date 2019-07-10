using System.Collections.Generic;
using System.Threading.Tasks;

using CoreFeature.BaseDataServices;

namespace CoreDomainFeature.CountryEntity
{
  public interface ICountryRepository : IReaderRepository<Country>
  {
    Task<IList<Country>> GetAllCountriesAsync();

    Task<IList<Country>> GetAllCountriesByCountryZoneIdAsync(int countryZoneId);
  }
}
