using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Util
{
  public abstract class PagedBaseRequest
  {
    [BindRequired]
    public virtual int Page { get; set; } = 0;
    [BindRequired]
    public virtual int PageSize { get; set; } = 20;
    [BindRequired]
    public virtual string OrderByProperty { get; set; } = string.Empty;
  }
}