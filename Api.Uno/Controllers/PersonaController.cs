using BusinessLogic.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Uno.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ApiUnoController<Persona>
    {
        public PersonaController(IService<Persona> service) : base(service)
        {
        }
    }
}
