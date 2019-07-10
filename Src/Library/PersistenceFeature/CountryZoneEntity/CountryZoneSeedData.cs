using CoreDomainFeature.CountryZoneEntity;

using Microsoft.EntityFrameworkCore;

namespace PersistenceFeature.CountryZoneEntity
{
  public static class CountryZoneSeedData
  {
    private static CountryZone[] CountryZoneList
    {
      get
      {
        return new CountryZone[]
        {
          new CountryZone
          {
            Id = 1,
            CountryZoneName = "NORTH AMERICA"
          },
          new CountryZone
          {
            Id = 2,
            CountryZoneName = "SOUTH AMERICA"
          },
          new CountryZone
          {
            Id = 3,
            CountryZoneName = "AFRICA"
          },
          new CountryZone
          {
            Id = 4,
            CountryZoneName = "ASIA"
          },
          new CountryZone
          {
            Id = 5,
            CountryZoneName = "Australia and Oceania"
          },
          new CountryZone
          {
            Id = 6,
            CountryZoneName = "Europe"
          },
          new CountryZone
          {
            Id = 7,
            CountryZoneName = "United Kingdom (UK)"
          }
        };
      }
    }

    public static void CreateCountryRegion(this ModelBuilder modelBuilder)
    {
      var countryZoneID = 0;
      modelBuilder.Entity<CountryZone>().HasData
      (
        CountryZoneList[countryZoneID++],
        CountryZoneList[countryZoneID++],
        CountryZoneList[countryZoneID++],
        CountryZoneList[countryZoneID++],
        CountryZoneList[countryZoneID++],
        CountryZoneList[countryZoneID++],
        CountryZoneList[countryZoneID++]
      );
    }
  }
}
