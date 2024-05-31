
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Pacientes;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Pacientes
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteUpdateController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;

        public PacienteUpdateController(IPacientesRepository pacientesRep)
        {
            _pacientesRepository = pacientesRep;
        }

        [HttpPut("Actualizar/{id}")]
        public IActionResult UpdatePaciente(int id, Paciente paciente)
        {
            try{
                _pacientesRepository.UpdatePaciente(id, paciente);
                return Ok("Paciente actualizado correctamente");
            }
            catch{
                return BadRequest("Error al actualizar paciente");
            }
        }
    }
}