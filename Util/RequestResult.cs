using FluentValidation.Results;

namespace Util
{
  public abstract class RequestResult<TData>
  {
    public virtual int StatusCode { get; set; } = StatusCodes.Status200OK;
    public virtual TData Data { get; set; }
    public virtual List<string> Errors { get; set; } = new();
    public virtual List<ValidationFailure> ValidationErrors { get; set; } = new();
    public virtual RequestResult<TData> BadRequest(string error)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      Errors.Add(error);
      Data = default(TData);
      return this;
    }
    public virtual RequestResult<TData> BadRequest(List<string> errors)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      Errors.AddRange(errors);
      Data = default(TData);
      return this;
    }
    public virtual RequestResult<TData> BadRequest(List<ValidationFailure> validationErrors)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      ValidationErrors.AddRange(validationErrors);
      Data = default(TData);
      return this;
    }
    public virtual RequestResult<TData> BadRequest(string error, List<ValidationFailure> validationErrors)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      Errors.Add(error);
      ValidationErrors.AddRange(validationErrors);
      Data = default(TData);
      return this;
    }
    public virtual RequestResult<TData> BadRequest(List<string> errors, List<ValidationFailure> validationErrors)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      Errors.AddRange(errors);
      ValidationErrors.AddRange(validationErrors);
      Data = default(TData);
      return this;
    }
    public virtual RequestResult<TData> NotFound()
    {
      StatusCode = StatusCodes.Status404NotFound;
      Data = default(TData);
      return this;
    }
    public virtual RequestResult<TData> Created(TData data)
    {
      StatusCode = StatusCodes.Status201Created;
      Data = data;
      return this;
    }
    public virtual RequestResult<TData> NoContent()
    {
      StatusCode = StatusCodes.Status204NoContent;
      Data = default(TData);
      return this;
    }
  }
}