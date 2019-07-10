using System.Collections.Generic;
using CoreDomainFeature.CountryEntity;

namespace CoreDomainFeature.CountryZoneEntity
{
  public class CountryZone : CountryZoneBaseType
  {
    public int Id { get; set; }

    public ICollection<Country> Countries { get; set; }
  }
}
