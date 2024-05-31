
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Citas;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Citas
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitasController : ControllerBase
    {
        private readonly ICitasRepository _citasRep;
        public CitasController(ICitasRepository citasRep)
        {
            _citasRep = citasRep;
        }

        [HttpGet("lista")]
        public IEnumerable<Cita> GetCitas()
        {
            try
            {
                return _citasRep.GetCitas();
            }
            catch
            {
                return (IEnumerable<Cita>)BadRequest("Error al traer las citas");
            }
        }

        [HttpGet("lista/{id}")]
        public Cita GetPacienteById(int id)
        {
            var cita = _citasRep.GetCitaById(id);

            if (!ModelState.IsValid)
            {
                NotFound("Error la cita no ha sido encontrada");
            }

            return cita;
        }
    }
}