
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Tratamientos;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Tratamientos
{
    [ApiController]
    [Route("api/[controller]")]
    public class TratamientosController : ControllerBase
    {
        private readonly ITratamientosRepository _tratamientiosRep;

        public TratamientosController(ITratamientosRepository tratamientiosRep)
        {
            _tratamientiosRep = tratamientiosRep;
        }

        [HttpGet("lista")]
        public IEnumerable<Tratamiento> GetTratamientos()
        {
            try
            {
                return _tratamientiosRep.GetTratamientos();
            }
            catch
            {
                return (IEnumerable<Tratamiento>)BadRequest("Error al traer los tratamientos");
            }
        }

        [HttpGet("lista/{id}")]
        public Tratamiento GetTratamientoById(int id)
        {
            var tratamiento = _tratamientiosRep.GetTratamientoById(id);

            if (!ModelState.IsValid)
            {
                NotFound("Error el tratamiento no ha sido encontrado");
            }

            return tratamiento;
        }
    }
}