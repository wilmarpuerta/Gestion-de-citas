
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Especialidades;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Especialidades
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadCreateController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRep;

        public EspecialidadCreateController(IEspecialidadesRepository especialidadesRep)
        {
            _especialidadesRep = especialidadesRep;
        }

        [HttpPost("Creacion")]
        public IActionResult CrearEspecialidad([FromBody] Especialidad especialidad)
        {
            try
            {
                _especialidadesRep.AddEspecialidad(especialidad);
                return Ok(especialidad);
            }
            catch
            {
                return BadRequest("Error al crear la especialidad");
            }
        }
        
    }
}