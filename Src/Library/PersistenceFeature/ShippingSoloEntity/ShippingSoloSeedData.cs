using CoreDomainFeature.ShippingSharedData;
using CoreDomainFeature.ShippingSoloEntity;

using Microsoft.EntityFrameworkCore;

namespace PersistenceFeature.ShippingSoloEntity
{
  public static class ShippingSoloSeedData
  {
    private static readonly RegionCount regionCount = new RegionCount();

    private static ShippingSolo[] ShippingSoloList
    {
      get
      {
        var shippingSoloID = 0;
        return new ShippingSolo[]
        {
          new ShippingSolo
          {
            Id = ++shippingSoloID,
            RegionNumber = regionCount.Count_1,
            PostageCost = 7.0M
          },
          new ShippingSolo
          {
            Id = ++shippingSoloID,
            RegionNumber = regionCount.Count_2,
            PostageCost = 7.25M
          },
          new ShippingSolo
          {
            Id = ++shippingSoloID,
            RegionNumber = regionCount.Count_3,
            PostageCost = 7.50M
          },
          new ShippingSolo
          {
            Id = ++shippingSoloID,
            RegionNumber = regionCount.Count_4,
            PostageCost = 6.0M
          },
          new ShippingSolo
          {
            Id = ++shippingSoloID,
            RegionNumber = regionCount.Count_5,
            PostageCost = 3.50M
          }
        };
      }
    }

    public static void CreateShippingSolo(this ModelBuilder modelBuilder)
    {
      var shippingSoloID = 0;
      modelBuilder.Entity<ShippingSolo>().HasData
      (
        ShippingSoloList[shippingSoloID++],
        ShippingSoloList[shippingSoloID++],
        ShippingSoloList[shippingSoloID++],
        ShippingSoloList[shippingSoloID++],
        ShippingSoloList[shippingSoloID++]
      );
    }
  }
}
