using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreFeature.BaseDataServices
{
  public interface IReaderRepository<T> where T : class
  {
    Task<List<T>> GetAllAsync();
    Task<T> GetItemByPredicateAsync(Expression<Func<T, bool>> predicate);
    Task<List<T>> GetListByPredicateAsync(Expression<Func<T, bool>> predicate);
  }
}