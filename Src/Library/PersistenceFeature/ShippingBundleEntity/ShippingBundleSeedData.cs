using CoreDomainFeature.ShippingBundleEntity;
using CoreDomainFeature.ShippingSharedData;

using Microsoft.EntityFrameworkCore;

namespace PersistenceFeature.ShippingBundleEntity
{
  public static class ShippingBundleSeedData
  {
    private static readonly RegionCount regionCount = new RegionCount();

    private static ShippingBundle[] ShippingBundleList
    {
      get
      {
        var shippingBundleID = 0;
        return new ShippingBundle[]
        {
          new ShippingBundle
          {
            Id = ++shippingBundleID,
            RegionNumber = regionCount.Count_1,
            PostageCost = 8.50M
          },
          new ShippingBundle
          {
            Id = ++shippingBundleID,
            RegionNumber = regionCount.Count_2,
            PostageCost = 8.99M
          },
          new ShippingBundle
          {
            Id = ++shippingBundleID,
            RegionNumber = regionCount.Count_3,
            PostageCost = 9.50M
          },
          new ShippingBundle
          {
            Id = ++shippingBundleID,
            RegionNumber = regionCount.Count_4,
            PostageCost = 7.0M
          },
          new ShippingBundle
          {
            Id = ++shippingBundleID,
            RegionNumber = regionCount.Count_5,
            PostageCost = 3.0M
          }
        };
      }
    }

    public static void CreateShippingBundle(this ModelBuilder modelBuilder)
    {
      var shippingBundleID = 0;
      modelBuilder.Entity<ShippingBundle>().HasData
      (
        ShippingBundleList[shippingBundleID++],
        ShippingBundleList[shippingBundleID++],
        ShippingBundleList[shippingBundleID++],
        ShippingBundleList[shippingBundleID++],
        ShippingBundleList[shippingBundleID++]
      );
    }
  }
}
