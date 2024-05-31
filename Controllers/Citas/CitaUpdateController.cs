
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Citas;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Citas
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitaUpdateController : ControllerBase
    {
        private readonly ICitasRepository _citasRep;
        public CitaUpdateController(ICitasRepository citasRep)
        {
            _citasRep = citasRep;
        }


        [HttpPut("Actualizar/{id}")]
        public IActionResult UpdatePaciente(int id, Cita cita)
        {
            try{
                _citasRep.UpdateCita(id, cita);
                return Ok("La cita se ha actualizado correctamente");
            }
            catch{
                return BadRequest("Error al actualizar la cita");
            }
        }
    }
}