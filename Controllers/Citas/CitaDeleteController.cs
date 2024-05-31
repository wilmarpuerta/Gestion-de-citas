
using Gestion_de_citas.Services.Citas;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Citas
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitaDeleteController : ControllerBase
    {
        private readonly ICitasRepository _citasRep;
        public CitaDeleteController(ICitasRepository citasRep)
        {
            _citasRep = citasRep;
        }

        [HttpPut("Eliminar/{id}")]
        public IActionResult CitaDelete(int id)
        {
            try{
                _citasRep.DeleteCita(id);
                return Ok("Cita eliminada correctamente");
            }
            catch{
                return BadRequest("Error al eliminar cita");
            }
        }
    }
}