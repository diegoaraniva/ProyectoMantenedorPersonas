using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PersonaService.Data;
using PersonaService.Models;

namespace PersonaService.Repositorios
{
    public class PersonaRepository
    {
        private readonly PersonaDBContext _context;

        public PersonaRepository(PersonaDBContext context)
        {
            _context = context;
        }

        public async Task<bool> AgregarPersona(AgregaPersona modeloPersona)
        {
            try
            {
                var parametros = new List<SqlParameter>
                {
                    new SqlParameter("@bActualiza", modeloPersona.bActualiza),
                    new SqlParameter("@nIdPersona", modeloPersona.nIdPersona),
                    new SqlParameter("@cNomPersona", modeloPersona.cNomPersona),
                    new SqlParameter("@cApePersona", modeloPersona.cApePersona),
                    new SqlParameter("@dFechaNacPersona", modeloPersona.dFechaNacPersona),
                    new SqlParameter("@nIdGenero", modeloPersona.nIdGenero),
                    new SqlParameter("@cDocumento", modeloPersona.cDocumento),
                    new SqlParameter("@cDireccionPersonal", modeloPersona.cDireccionPersonal),
                    new SqlParameter("@nIdZone", modeloPersona.nIdZone),
                    new SqlParameter("@cDireccionTrabajo", modeloPersona.cDireccionTrabajo),
                    new SqlParameter("@cCorreoPersona", modeloPersona.cCorreoPersona),
                    new SqlParameter("@nIdEstadoCivil", modeloPersona.nIdEstadoCivil),
                    new SqlParameter("@vFotoPersona", modeloPersona.vFotoPersona)
                };

                await _context.Database.ExecuteSqlRawAsync("SP_Persona_AgregaPersona @bActualiza, @nIdPersona, " +
                    "@cNomPersona, @cApePersona, @dFechaNacPersona, @nIdGenero, @cDocumento, @cDireccionPersonal, " +
                    "@nIdZone, @cDireccionTrabajo, @cCorreoPersona, @nIdEstadoCivil, @vFotoPersona", parametros);

                return true;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<FiltrarPersona>> ObtenerPersona(int nFiltro, string cBusqueda = "") {
            try
            {
                var personas = await _context.FiltrarPersonas
                    .FromSqlRaw("SP_Persona_RecuperaPersona @cBusqueda, @nFiltro",
                    new SqlParameter("@cBusqueda", cBusqueda),
                    new SqlParameter("@nFiltro", nFiltro))
                    .ToListAsync();
                return personas;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool>EliminarPersona(int nIdPersona)
        {
            try
            {
                await _context.Database.ExecuteSqlRawAsync("SP_Persona_EliminaPersona @nIdPersona",
                    new SqlParameter("@nIdPersona", nIdPersona));
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
