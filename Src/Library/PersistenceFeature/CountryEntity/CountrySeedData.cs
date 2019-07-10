using CoreDomainFeature.CountryEntity;
using CoreDomainFeature.LocationSharedData;

using Microsoft.EntityFrameworkCore;

namespace PersistenceFeature.CountryEntity
{
  public static class CountrySeedData
  {
    public static Country[] CountryList
    {
      get
      {
        var iDList = 0;
        return new Country[]
        {
          #region RegionOne_NORTH_AMERICA
          //10
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Anguilla (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Antigua and Barbuda"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Bahamas"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Barbados"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Belize"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Bermuda"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Bermuda (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Bonaire (Netherlands)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "British Virgin Islands (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Canada"
          },

          //20
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Cayman Islands (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Clipperton Island (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Costa Rica"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Curaçao (Netherlands)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Cuba"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Dominica"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Dominican Republic"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "El Salvador"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Grenada"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Guatemala"
          },

          //30
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Guadeloupe (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Haiti"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Honduras"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Jamaica"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Mexico"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Martinique (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Montserrat (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Nicaragua"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Panama"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Puerto Rico (USA)"
          },

          //40
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "St. Kitts and Nevis"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "St. Lucia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "St. Vincent and The Grenadines"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Saba (Netherlands)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Saint Barthélemy (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Saint Martin (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Saint Pierre and Miquelon (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Sint Eustatius (Netherlands)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Sint Maarten (Netherlands)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Trinidad and Tobago"
          },

          //40
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Turks and Caicos Islands (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "United States of America"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "US Virgin Islands (USA)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Anguilla (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_NORTH_AMERICA,
            CountryName = "Aruba (Netherlands)"
          },
          #endregion

          #region RegionOne_SOUTH_AMERICA
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Argentina"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Bolivia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Brazil"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Chile"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Colombia"
          },

          //50
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Ecuador"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Falkland Islands (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "French Guiana (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Guyana"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Paraguay"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Peru"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Suriname"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "South Georgia and South Sandwich Islands (UK)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Uruguay"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_SOUTH_AMERICA,
            CountryName = "Venezuela"
          },
          #endregion

          #region RegionOne_AFRICA
          //60
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Algeria"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Angola"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Benin"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Botswana"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Burkina Faso"
          },
          new Country()
          {
           Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Burundi"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Cabo Verde"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Cameroon"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Central African Republic"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Chad"
          },

          //70
          new Country()
          {
           Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Comoros"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Congo, Republic of the"
          },
          new Country()
          {
           Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Congo, Democratic Republic of the"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Cote d'Ivoire"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Djibouti"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Egypt"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Equatorial Guinea"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Eritrea"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Gabon"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Gambia"
          },

          //80
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Ghana"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Guinea"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Guinea-Bissau"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Kenya"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Lesotho"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Liberia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Libya"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Madagascar"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Malawi"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Mali"
          },

          //90
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Mauritania"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Mauritius"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Morocco"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Mozambique"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Namibia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Niger"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Nigeria"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Rwanda"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Sao Tome and Principe"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Senegal"
          },

          //100
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Seychelles"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Sierra Leone"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Somalia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "South Africa"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "South Sudan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Sudan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Swaziland"
          },
          new Country()
          {
           Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Tanzania"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Togo"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Tunisia"
          },

          //110
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Uganda"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Zambia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionOne_AFRICA,
            CountryName = "Zimbabwe"
          },
          #endregion

          #region RegionTwo_ASIA
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Afghanistan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Armenia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Azerbaijan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Bahrain"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Bangladesh"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Bhutan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Brunei"
          },

          //120
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Cambodia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "China"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Georgia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "India"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Indonesia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Iran"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Iraq"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Israel"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Japan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Jordan"
          },

          //130
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Kazakhstan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Kuwait"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Kyrgyzstan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Laos"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Lebanon"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Malaysia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Maldives"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Mongolia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Myanmar (Burma)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Nepal"
          },

          //140
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "North Korea"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Oman"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Pakistan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Palestine"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Philippines"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Qatar"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Russia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Saudi Arabia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Singapore"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "South Korea"
          },

          //150
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Sri Lanka"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Syria"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Taiwan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Tajikistan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Thailand"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Timor-Leste"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Turkey"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Turkmenistan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "United Arab Emirates"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Uzbekistan"
          },

          //160
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Vietnam"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionTwo_ASIA,
            CountryName = "Yemen"
          },
          #endregion

          #region RegionThree_AUSTRALIA_AND_OCEANIA
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Australia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "American Samoa (USA)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Cook Islands (New Zealand)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Fiji"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "French Polynesia (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Guam (USA)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Kiribati"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Marshall Islands"
          },

          //170
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Micronesia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Nauru"
          },
          new Country()
          {
           Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "New Zealand"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "New Caledonia (France)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Niue (New Zealand)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Norfolk Island (Australia)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Northern Mariana Islands (USA)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Palau"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Papua New Guinea"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Pitcairn Islands (UK)"
          },

          //180
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Samoa"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Solomon Islands"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Tonga"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Tuvalu"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Tokelau (New Zealand)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Vanuatu"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionThree_AUSTRALIA_AND_OCEANIA,
            CountryName = "Wallis and Futuna (France)"
          },
          #endregion

          #region RegionFour_EUROPE
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Albania"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Andorra"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Armenia"
          },

          //190
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Austria"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Azerbaijan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Belarus"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Belgium"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Bosnia and Herzegovina"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Bulgaria"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Croatia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Cyprus"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Czech Republic"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Denmark"
          },

          //200
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Greenland (Denmark)"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Estonia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Finland"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "France"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Germany"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Greece"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Hungary"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Iceland"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Ireland"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Italy"
          },

          //210
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Kazakhstan"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Kosovo"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Latvia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Liechtenstein"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Lithuania"
          },
          new Country()
          {
           Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Luxembourg"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Macedonia"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Malta"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Moldova"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Monaco"
          },

          //220
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Montenegro"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Netherlands"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Norway"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFour_EUROPE,
            CountryName = "Russia"
          },
          #endregion

          #region RegionFive_UNITED_KINGDOM
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFive_UNITED_KINGDOM,
            CountryName = "England",
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFive_UNITED_KINGDOM,
            CountryName = "Northern Ireland"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFive_UNITED_KINGDOM,
            CountryName = "Scotland"
          },
          new Country()
          {
            Id = ++iDList,
            CountryZoneId = CountryRegionInMemoryData.RegionFive_UNITED_KINGDOM,
            CountryName = "Wales"
          }
          #endregion
        };
      }
    }

    public static void CreateCountry(this ModelBuilder modelBuilder)
    {
      var countryID = 0;
      modelBuilder.Entity<Country>().HasData
      (
        //1
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //2
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //3
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //4
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //5
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //6
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //7
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //8
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //9
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //10
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //11
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //12
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //13
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //14
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //15
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //16
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //17
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //18
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //19
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //20
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //21
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //22
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        //23
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++],
        CountryList[countryID++]
      );
    }
  }
}

//protected override void OnModelCreating(ModelBuilder modelBuilder)
