using Data;
using Interface;
using Microsoft.EntityFrameworkCore;
using Util;

namespace Repository
{
  public abstract class Repository<T> : IRepository<T> where T : class
  {
    protected readonly AppDbContext Db;
    protected readonly DbSet<T> DbSet;
    public IUnitOfWork UnitOfWork => Db;
    public Repository(
      AppDbContext dbContext
    )
    {
      Db = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
      DbSet = Db.Set<T>();
    }
    public T Add(T entity)
    {
      return DbSet.Add(entity).Entity;
    }
    public void Delete(T entity)
    {
      DbSet.Remove(entity);
    }
    public async Task<List<T>> Get()
    {
      return await DbSet.AsNoTracking().ToListAsync();
    }
    public async Task<T> GetById(int id)
    {
      return await DbSet.FindAsync(id);
    }
    public async Task<PagedResult<T>> GetPaged(int page, int pageSize, string orderByProperty)
    {
      var result = new PagedResult<T>();
      result.RowCount = await DbSet.CountAsync();
      result.CurrentPage = page;
      result.PageSize = pageSize;
      result.PageCount = (int)Math.Ceiling((double)result.RowCount / pageSize);
      var skip = page * pageSize;
      result.Results = DbSet
                        .OrderBy(p => p.GetType().GetProperty(orderByProperty).GetValue(p, null))
                        .Skip(skip)
                        .Take(pageSize)
                        .ToList();
      return result;
    }
    public void Update(T entity)
    {
      DbSet.Update(entity);
    }

  }
}