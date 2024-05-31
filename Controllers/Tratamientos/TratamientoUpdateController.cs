
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Tratamientos;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Tratamientos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TratamientoUpdateController : ControllerBase
    {
        private readonly ITratamientosRepository _tratamientiosRep;

        public TratamientoUpdateController(ITratamientosRepository tratamientiosRep)
        {
            _tratamientiosRep = tratamientiosRep;
        }

        [HttpPut("Actualizar/{id}")]
        public IActionResult UpdateTratamiento(int id, Tratamiento tratamiento)
        {
            try{
                _tratamientiosRep.UpdateTratamiento(id, tratamiento);
                return Ok("Tratamiento actualizado correctamente");
            }
            catch{
                return BadRequest("Error al actualizar tratamiento");
            }
        }
    }
}