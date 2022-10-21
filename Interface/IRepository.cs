using Util;

namespace Interface
{
  public interface IRepository<T> where T : class
  {
    IUnitOfWork UnitOfWork { get; }
    Task<T> GetById(int id);
    Task<List<T>> Get();
    Task<PagedResult<T>> GetPaged(int page, int pageSize, string orderByProperty);
    T Add(T entity);
    void Update(T entity);
    void Delete(T entity);
  }
}