
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Pacientes;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Pacientes
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly IPacientesRepository _pacientesRepository;
        public PacientesController(IPacientesRepository pacientesRep)
        {
            _pacientesRepository = pacientesRep;
        }

        [HttpGet("lista")]
        public IEnumerable<Paciente> GetPacientes()
        {
            return _pacientesRepository.GetPacientes();
        }

        [HttpGet("lista/{id}")]
        public Paciente GetPacienteById(int id)
        {
            return _pacientesRepository.GetPacienteById(id);
        }
    }
}