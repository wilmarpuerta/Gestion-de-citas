
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Medicos;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Medicos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoUpdateController : ControllerBase
    {
        private readonly IMedicosRepository _medicosRep;

        public MedicoUpdateController(IMedicosRepository medicosRep)
        {
            _medicosRep = medicosRep;
        }

        [HttpPut("Actualizar/{id}")]
        public IActionResult UpdatePaciente(int id, Medico medico)
        {
            try{
                _medicosRep.UpdateMedico(id, medico);
                return Ok("Medico actualizado correctamente");
            }
            catch{
                return BadRequest("Error al actualizar medico");
            }
        }
    }
}