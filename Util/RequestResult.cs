using FluentValidation.Results;

namespace Util
{
  public class RequestResult<TData> where TData : class
  {
    public int StatusCode { get; set; } = StatusCodes.Status200OK;
    public TData Data { get; set; }
    public List<string> Errors { get; set; } = new();
    public List<ValidationFailure> ValidationErrors { get; set; } = new();
    public RequestResult<TData> BadRequest(string error)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      Errors.Add(error);
      Data = default(TData);
      return this;
    }
    public RequestResult<TData> BadRequest(List<string> errors)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      Errors.AddRange(errors);
      Data = default(TData);
      return this;
    }
    public RequestResult<TData> BadRequest(List<ValidationFailure> validationErrors)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      ValidationErrors.AddRange(validationErrors);
      Data = default(TData);
      return this;
    }
    public RequestResult<TData> BadRequest(string error, List<ValidationFailure> validationErrors)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      Errors.Add(error);
      ValidationErrors.AddRange(validationErrors);
      Data = default(TData);
      return this;
    }
    public RequestResult<TData> BadRequest(List<string> errors, List<ValidationFailure> validationErrors)
    {
      StatusCode = StatusCodes.Status400BadRequest;
      Errors.AddRange(errors);
      ValidationErrors.AddRange(validationErrors);
      Data = default(TData);
      return this;
    }
    public RequestResult<TData> NotFound()
    {
      StatusCode = StatusCodes.Status404NotFound;
      Data = default(TData);
      return this;
    }
    public RequestResult<TData> Created(TData data)
    {
      StatusCode = StatusCodes.Status201Created;
      Data = data;
      return this;
    }
    public RequestResult<TData> NoContent()
    {
      StatusCode = StatusCodes.Status204NoContent;
      Data = default(TData);
      return this;
    }
    public RequestResult<TData> OK(TData data)
    {
      StatusCode = StatusCodes.Status200OK;
      Data = data;
      return this;
    }
  }
}