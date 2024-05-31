
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Tratamientos;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Tratamientos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TratamientoCreateController : ControllerBase
    {
        private readonly ITratamientosRepository _tratamientiosRep;

        public TratamientoCreateController(ITratamientosRepository tratamientiosRep)
        {
            _tratamientiosRep = tratamientiosRep;
        }

        [HttpPost("Creacion")]
        public IActionResult CrearTratamiento([FromBody] Tratamiento tratamiento)
        {
            try
            {
                _tratamientiosRep.AddTratamiento(tratamiento);
                return Ok(tratamiento);
            }
            catch
            {
                return BadRequest("Error al crear tratamiento");
            }
        }
        
    }
}