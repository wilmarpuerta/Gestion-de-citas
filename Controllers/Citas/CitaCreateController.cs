
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Citas;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Citas
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitaCreateController : ControllerBase
    {
        private readonly ICitasRepository _citasRep;
        public CitaCreateController(ICitasRepository citasRep)
        {
            _citasRep = citasRep;
        }

        [HttpPost("Creacion")]
        public IActionResult CrearCita([FromBody] Cita cita)
        {
            try
            {
                _citasRep.AddCita(cita);
                return Ok(cita);
            }
            catch
            {
                return BadRequest("Error al crear cita");
            }
        }
        
    }
}