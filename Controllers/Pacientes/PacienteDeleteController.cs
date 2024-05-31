
using Gestion_de_citas.Services.Pacientes;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Pacientes
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteDeleteController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;

        public PacienteDeleteController(IPacientesRepository pacientesRep)
        {
            _pacientesRepository = pacientesRep;
        }

        [HttpPut("Eliminar/{id}")]
        public IActionResult PacienteDelete(int id)
        {
            try{
                _pacientesRepository.DeletePaciente(id);
                return Ok("Paciente eliminado correctamente");
            }
            catch{
                return BadRequest("Error al eliminar paciente");
            }
        }
    }
}