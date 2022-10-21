using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Util
{
  public class PagedBaseRequest
  {
    [BindRequired]
    public int Page { get; set; } = 0;
    [BindRequired]
    public int PageSize { get; set; } = 20;
    [BindRequired]
    public string OrderByProperty { get; set; } = string.Empty;
  }
}