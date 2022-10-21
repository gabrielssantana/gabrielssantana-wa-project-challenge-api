namespace Interface
{
  public interface IUnitOfWork
  {
    Task<bool> Commit();
  }
}