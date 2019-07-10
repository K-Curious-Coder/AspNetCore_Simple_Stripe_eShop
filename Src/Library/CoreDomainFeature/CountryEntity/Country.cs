using CoreDomainFeature.CountryZoneEntity;

namespace CoreDomainFeature.CountryEntity
{
  public class Country : CountryBaseType
  {
    public int Id { get; set; }
    public CountryZone CountryZone { get; set; }
  }
}
