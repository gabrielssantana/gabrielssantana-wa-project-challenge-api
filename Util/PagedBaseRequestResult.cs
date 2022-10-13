namespace Util
{
  public abstract class PagedBaseRequestResult<TData> : RequestResult<TData>
  {
    public virtual int TotalPages { get; set; }
    public virtual int TotalRegisters { get; set; }
    public virtual new List<TData> Data { get; set; } = new();
  }
}