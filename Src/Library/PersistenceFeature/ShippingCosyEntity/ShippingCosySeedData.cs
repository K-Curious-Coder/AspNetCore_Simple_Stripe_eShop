using CoreDomainFeature.ShippingCosyEntity;
using CoreDomainFeature.ShippingSharedData;

using Microsoft.EntityFrameworkCore;

namespace PersistenceFeature.ShippingCosyEntity
{
  public static class ShippingCosySeedData
  {
    private static readonly RegionCount regionCount = new RegionCount();

    private static ShippingCosy[] ShippingCosyList
    {
      get
      {
        var shippingCosyID = 0;
        return new ShippingCosy[]
        {
          new ShippingCosy
          {
            Id = ++shippingCosyID,
            RegionNumber = regionCount.Count_1,
            PostageCost = 14.0M
          },
          new ShippingCosy
          {
            Id = ++shippingCosyID,
            RegionNumber = regionCount.Count_2,
            PostageCost = 14.50M
          },
          new ShippingCosy
          {
            Id = ++shippingCosyID,
            RegionNumber = regionCount.Count_3,
            PostageCost = 15.50M
          },
          new ShippingCosy
          {
            Id = ++shippingCosyID,
            RegionNumber = regionCount.Count_4,
            PostageCost = 11.0M
          },
          new ShippingCosy
          {
            Id = ++shippingCosyID,
            RegionNumber = regionCount.Count_5,
            PostageCost = 5.50M
          }
        };
      }
    }

    public static void CreateShippingCosy(this ModelBuilder modelBuilder)
    {
      var shippingCosyID = 0;
      modelBuilder.Entity<ShippingCosy>().HasData
      (
        ShippingCosyList[shippingCosyID++],
        ShippingCosyList[shippingCosyID++],
        ShippingCosyList[shippingCosyID++],
        ShippingCosyList[shippingCosyID++],
        ShippingCosyList[shippingCosyID++]
      );
    }
  }
}
