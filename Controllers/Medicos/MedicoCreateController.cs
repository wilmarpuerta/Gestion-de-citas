
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Medicos;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Medicos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoCreateController : ControllerBase
    {
        private readonly IMedicosRepository _medicosRep;

        public MedicoCreateController(IMedicosRepository medicosRep)
        {
            _medicosRep = medicosRep;
        }

        [HttpPost("Creacion")]
        public IActionResult CrearMedico([FromBody] Medico medico)
        {
            try
            {
                _medicosRep.AddMedico(medico);
                return Ok(medico);
            }
            catch
            {
                return BadRequest("Error al crear medico");
            }
        }
        
    }
}