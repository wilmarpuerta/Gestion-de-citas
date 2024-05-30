
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Pacientes;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Pacientes
{
    public class PacienteUpdateController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;

        public PacienteUpdateController(IPacientesRepository pacientesRep)
        {
            _pacientesRepository = pacientesRep;
        }

        [HttpPut("Actualizar")]
        public IActionResult PacienteUpdate(int id, [FromBody] Paciente paciente)
        {
            _pacientesRepository.UpdatePaciente(id, paciente);
            return Ok("Paciente actualizado correctamente");
        }
    }
}