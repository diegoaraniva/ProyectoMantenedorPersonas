using Microsoft.AspNetCore.Mvc;
using PersonaService.Repositorios;

namespace PersonaService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EliminarPersonasController : Controller
    {

        private readonly PersonaRepository _personaData;
        public EliminarPersonasController(PersonaRepository personaData)
        {
            _personaData = personaData;
        }

        [HttpDelete]
        public async Task<IActionResult> EliminarPersonas([FromQuery] int nIdPersona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await _personaData.EliminarPersona(nIdPersona);
                return Ok("Persona eliminada correctamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
    }
}
