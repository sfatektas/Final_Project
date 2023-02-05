using MSS_NewsWeb.Common.Interfaces;

namespace MSS_NewsWeb.Common
{
    public class Response : IResponse
    {
        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }

        public Response(ResponseType responseType, string message) : this(responseType)
        {
            Message = message;
        }

        public ResponseType ResponseType { get; set; }

        public string Message { get; set; }

    }
    public class Response<T> : Response, IResponse<T>
    {
        public T Data { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }

        public Response(ResponseType responseType, T data) : base(responseType)
        {
            Data = data;
        }

        public Response(ResponseType responseType , string message , T data) : base(responseType,message)
        {
            this.Data = data;
        }

        public Response(ResponseType responseType, string message, T data, List<ValidationError> validationErrors) : this(responseType,message,data) 
        {
            this.ValidationErrors = validationErrors;
        }

    }
}
    