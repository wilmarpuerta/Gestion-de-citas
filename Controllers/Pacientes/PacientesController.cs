
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
            try
            {
                return _pacientesRepository.GetPacientes();
            }
            catch
            {
                return (IEnumerable<Paciente>)BadRequest("Error al traer los pacientes");
            }
        }

        [HttpGet("lista/{id}")]
        public Paciente GetPacienteById(int id)
        {
            var paciente = _pacientesRepository.GetPacienteById(id);

            if (!ModelState.IsValid)
            {
                NotFound("Error el paciente no ha sido encontrado");
            }

            return paciente;
        }
    }
}