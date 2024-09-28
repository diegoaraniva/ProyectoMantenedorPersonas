using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PersonaService.Models;
using PersonaService.Repositorios;

namespace PersonaService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrarPersonasController : Controller
    {
        private readonly PersonaRepository _personaData;

        public RegistrarPersonasController(PersonaRepository personaData)
        {
            _personaData = personaData;
        }

        [HttpPost]
        public async Task<IActionResult> Insertar([FromBody] AgregaPersona modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await _personaData.AgregarPersona(modelo);
                return Ok("Persona registrada correctamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
