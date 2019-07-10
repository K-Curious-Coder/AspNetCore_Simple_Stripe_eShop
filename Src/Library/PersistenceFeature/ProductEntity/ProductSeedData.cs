using CoreDomainFeature.ProductEntity;

using Microsoft.EntityFrameworkCore;

namespace PersistenceFeature.ProductEntity
{
  public static class ProductSeedData
  {
    private static Product[] ProductList
    {
      get
      {
        var productID = 0;
        return new Product[]
        {
          new Product
          {
            Id = ++productID,
            CurrentProductId = 1,
            ProductName = "Product A",
            ProductDescription = "Product A - Description",
            ProductPrice = 14.99m
          },
          new Product
          {
            Id = ++productID,
            CurrentProductId = 2,
            ProductName = "Product B",
            ProductDescription = "Product B - Description",
            ProductPrice = 32.99m
          },
          new Product
          {
            Id = ++productID,
            CurrentProductId = 3,
            ProductName = "Product C",
            ProductDescription = "Product C - Description",
            ProductPrice = 54.99m
          }
        };
      }
    }

    public static void CreateProduct(this ModelBuilder modelBuilder)
    {
      var productID = 0;
      modelBuilder.Entity<Product>().HasData
      (
        ProductList[productID++],
        ProductList[productID++],
        ProductList[productID++]
      );
    }
  }
}
