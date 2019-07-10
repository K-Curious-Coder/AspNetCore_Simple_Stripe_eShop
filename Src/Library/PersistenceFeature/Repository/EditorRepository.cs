using System.Threading.Tasks;

using CoreFeature.BaseDataServices;

namespace PersistenceFeature.Repository
{
  public class EditorRepository<T> : IEditorRepository<T> where T : class
  {
    private readonly ApplicationDbContext dbContext;

    public EditorRepository(ApplicationDbContext dbContext) => this.dbContext = dbContext;

    public ApplicationDbContext GetApplicationDbContext() => this.dbContext;

    public async Task CreateAsync(T t) => await this.dbContext.Set<T>().AddAsync(t);

    public void Remove(T t) => this.dbContext.Set<T>().Remove(t);

    public void Update(T t) => this.dbContext.Set<T>().Update(t);
  }
}
