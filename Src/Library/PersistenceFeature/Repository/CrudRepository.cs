using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using CoreFeature.BaseDataServices;

using Microsoft.EntityFrameworkCore;

namespace PersistenceFeature.Repository
{
  public class CrudRepository<T> : IRepository<T> where T : class
  {
    private readonly ApplicationDbContext dbContext;

    public CrudRepository(ApplicationDbContext dbContext) => this.dbContext = dbContext;

    public ApplicationDbContext GetApplicationDbContext() => this.dbContext;

    public async Task<List<T>> GetAllAsync() => await this.dbContext.Set<T>().ToListAsync();

    public async Task<List<T>> GetListByPredicateAsync(Expression<Func<T, bool>> predicate) => await this.dbContext.Set<T>().Where(predicate).ToListAsync();

    public async Task<T> GetItemByPredicateAsync(Expression<Func<T, bool>> predicate) => await this.dbContext.Set<T>().FirstOrDefaultAsync(predicate);

    public async Task CreateAsync(T t) => await this.dbContext.Set<T>().AddAsync(t);

    public void Remove(T t) => this.dbContext.Set<T>().Remove(t);

    public void Update(T t) => this.dbContext.Set<T>().Update(t);
  }
}
