namespace API.Errors
{
    public class ApiResponse
    {

        public int StatusCode {get; set;}
        public string Message {get; set;}
        
        public ApiResponse()
        {
        }

        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }
          private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request has been made",
                401 => "Authorized, you are not!",
                404 => "Resource not found",
                500 => "An error on the server occured. Why is that the case?",
                _ => null
            };
        }
    }
}