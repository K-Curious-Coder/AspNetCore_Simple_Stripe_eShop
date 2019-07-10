using System.Threading.Tasks;

namespace CoreFeature.BaseDataServices
{
  public interface IEditorRepository<T> where T : class
  {
    Task CreateAsync(T t);

    void Remove(T t);

    void Update(T t);
  }
}