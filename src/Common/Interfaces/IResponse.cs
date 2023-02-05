using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace MSS_NewsWeb.Common.Interfaces
{
    public interface IResponse
    {
        public ResponseType ResponseType { get; set; }

        public string Message { get; set; }
    }

    public interface IResponse<T> : IResponse
    {
        public T Data { get; set; }

        public List<ValidationError> ValidationErrors { get; set; }

    }

    public class ValidationError
    {
        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }

        public ValidationError(string errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

    }
}
