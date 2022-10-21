namespace Util
{
  public class PagedBaseRequestResult<TData> : RequestResult<TData> where TData : class
  {
    public int CurrentPage { get; set; }
    public int PageCount { get; set; }
    public int PageSize { get; set; }
    public int RowCount { get; set; }
    public new List<TData> Data { get; set; } = new();
  }
}