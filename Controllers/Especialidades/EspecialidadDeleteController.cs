
using Gestion_de_citas.Services.Especialidades;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Especialidades
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadDeleteController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRep;

        public EspecialidadDeleteController(IEspecialidadesRepository especialidadesRep)
        {
            _especialidadesRep = especialidadesRep;
        }

        [HttpPut("Eliminar/{id}")]
        public IActionResult EspecialidadDelete(int id)
        {
            try{
                _especialidadesRep.DeleteEspecialidad(id);
                return Ok("Especialidad eliminada correctamente");
            }
            catch{
                return BadRequest("Error al eliminar especialidad");
            }
        }
    }
}