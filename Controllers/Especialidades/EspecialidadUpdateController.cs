
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Especialidades;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Especialidades
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadUpdateController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRep;

        public EspecialidadUpdateController(IEspecialidadesRepository especialidadesRep)
        {
            _especialidadesRep = especialidadesRep;
        }

        [HttpPut("Actualizar/{id}")]
        public IActionResult PutEspecialidad(int id, Especialidad especialidad)
        {
            try{
                _especialidadesRep.UpdateEspecialidad(id, especialidad);
                return Ok("Especialidad actualizada correctamente");
            }
            catch{
                return BadRequest("Error al actualizar especialidad");
            }
        }
    }
}