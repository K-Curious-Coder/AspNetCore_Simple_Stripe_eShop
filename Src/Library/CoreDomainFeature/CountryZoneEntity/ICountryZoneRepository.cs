using System.Collections.Generic;
using System.Threading.Tasks;

using CoreFeature.BaseDataServices;

namespace CoreDomainFeature.CountryZoneEntity
{
  public interface ICountryZoneRepository : IReaderRepository<CountryZone>
  {
    Task<IList<CountryZone>> GetAllCountryZonesAsync();
  }
}
