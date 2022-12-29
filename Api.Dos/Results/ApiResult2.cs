using Entities.Models;

namespace Api.Dos.Results
{
    public class ApiResult2
    {
        public string Message { get; set; }
        public bool Error { get; set; }
        public Persona Data { get; set; }
        public ApiResult2()
        {
        }
    }
}
