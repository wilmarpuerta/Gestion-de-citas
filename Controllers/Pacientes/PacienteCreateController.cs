
using Gestion_de_citas.Dtos;
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Pacientes;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Pacientes
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteCreateController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;

        public PacienteCreateController(IPacientesRepository pacientesRep)
        {
            _pacientesRepository = pacientesRep;
        }

        [HttpPost("Creacion")]
        public IActionResult CrearPaciente([FromBody] PacienteDto paciente)
        {
            _pacientesRepository.AddPaciente(paciente);
            return Ok(paciente);
        }
        
    }
}