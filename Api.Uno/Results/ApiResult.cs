namespace Api.Uno.Results
{
    public class ApiResult
    {
        public string Message { get; set; }
        public bool Error { get; set; }
        public Object Data { get; set; }
        public ApiResult()
        {
        }
    }
}
