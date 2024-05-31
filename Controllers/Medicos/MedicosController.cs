
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Medicos;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Medicos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicosController : ControllerBase
    {
        private readonly IMedicosRepository _medicosRep;

        public MedicosController(IMedicosRepository medicosRep)
        {
            _medicosRep = medicosRep;
        }

        [HttpGet("lista")]
        public IEnumerable<Medico> GetMedicos()
        {
            try
            {
                return _medicosRep.GetMedicos();
            }
            catch
            {
                return (IEnumerable<Medico>)BadRequest("Error al traer los medicos");
            }
        }

        [HttpGet("lista/{id}")]
        public Medico GetMedicoById(int id)
        {
            var medico = _medicosRep.GetMedicoById(id);

            if (!ModelState.IsValid)
            {
                NotFound("Error el medico no ha sido encontrado");
            }

            return medico;
        }
    }
}