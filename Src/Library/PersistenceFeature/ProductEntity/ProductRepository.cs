using CoreDomainFeature.ProductEntity;

using PersistenceFeature.Repository;

namespace PersistenceFeature.ProductEntity
{
  public class ProductRepository : ReaderRepository<Product>, IProductRepository
  {
    public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
  }
}
