using Api.Dos.Results;
using BusinessLogic.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Api.Dos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiDosController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = new ApiResult();
            var urlApiExterna = "https://localhost:7179/api/Persona";
            using var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(urlApiExterna);
                if (!response.IsSuccessStatusCode)
                {
                    return BadRequest(result);
                }
                string jsonSerializado = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult>(jsonSerializado)!;
            }
            catch (Exception e)
            {
                return Conflict(e.Message);
            }
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(int id)
        {
            var result = new ApiResult();
            Persona persona = new Persona();
            var urlApiExterna = "https://localhost:7179/api/Persona";
            using var client = new HttpClient();
            try
            {
                var response = await client.GetAsync($"{urlApiExterna}?parametroEsperado={id}");
                if (!response.IsSuccessStatusCode)
                {
                    return BadRequest(result);
                }
                string jsonSerializado = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResult>(jsonSerializado)!;
                foreach (var item in result.Data)
                {
                    if (item.Id == id)
                    {
                        persona = item;
                    }
                }
            }
            catch (Exception e)
            {
                return Conflict(e.Message);
            }
            return Ok(new ApiResult2
            {
                Message = "string",
                Data = persona
            });
        }


    }
}
