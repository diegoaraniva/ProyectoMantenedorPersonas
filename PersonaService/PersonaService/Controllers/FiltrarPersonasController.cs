using Microsoft.AspNetCore.Mvc;
using PersonaService.Repositorios;

namespace PersonaService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltrarPersonasController : Controller
    {
        private readonly PersonaRepository _personaData;
        public FiltrarPersonasController(PersonaRepository personaData)
        {
            _personaData = personaData;
        }

        [HttpGet]
        public async Task<IActionResult> FiltrarPersonas([FromQuery] int nFiltro, [FromQuery] string cBusqueda = "")
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var resultado = await _personaData.ObtenerPersona(nFiltro, cBusqueda);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
    }
}
