using Entities.Models;

namespace Api.Dos.Results
{
    public class ApiResult
    {
        public string Message { get; set; }
        public bool Error { get; set; }
        public List<Persona> Data { get; set; }
        public ApiResult()
        {
        }
    }
}
