
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Tratamientos;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Tratamientos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TratamientoDeleteController : ControllerBase
    {
        private readonly ITratamientosRepository _tratamientiosRep;

        public TratamientoDeleteController(ITratamientosRepository tratamientiosRep)
        {
            _tratamientiosRep = tratamientiosRep;
        }

        [HttpPut("Eliminar/{id}")]
        public IActionResult TratamientoDelete(int id)
        {
            try{
                _tratamientiosRep.DeleteTratamiento(id);
                return Ok("Tratamiento eliminado correctamente");
            }
            catch{
                return BadRequest("Error al eliminar tratamiento");
            }
        }
    }
}