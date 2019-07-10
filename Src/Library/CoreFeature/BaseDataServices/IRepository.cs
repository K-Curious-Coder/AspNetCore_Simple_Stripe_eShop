using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreFeature.BaseDataServices
{
  //public interface IRepository<T> where T : class
  //{
  //  Task<List<T>> GetAllAsync();
  //  Task<T> GetItemByPredicateAsync(Expression<Func<T, bool>> predicate);
  //  Task<List<T>> GetListByPredicateAsync(Expression<Func<T, bool>> predicate);

  //  Task CreateAsync(T t);
  //  Task UpdateAsync(T t);
  //  Task RemoveAsync(T t);
  //}

  public interface IRepository<T> : IReaderRepository<T>, IEditorRepository<T> where T : class
  {
    //Task<List<T>> GetAllAsync();
    //Task<T> GetItemByPredicateAsync(Expression<Func<T, bool>> predicate);
    //Task<List<T>> GetListByPredicateAsync(Expression<Func<T, bool>> predicate);

    //Task CreateAsync(T t);
    //Task UpdateAsync(T t);
    //Task RemoveAsync(T t);
  }

}

//IRepository<T> : IReaderRepository<T>, IEditorRepository<T> where T : class
//public interface IRepository<T> : IReaderRepository<T> where T : class
//IEditorRepository<T>
