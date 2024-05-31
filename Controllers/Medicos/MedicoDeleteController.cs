
using Gestion_de_citas.Services.Medicos;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Medicos
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicoDeleteController : ControllerBase
    {
        private readonly IMedicosRepository _medicosRep;

        public MedicoDeleteController(IMedicosRepository medicosRep)
        {
            _medicosRep = medicosRep;
        }

        [HttpPut("Eliminar/{id}")]
        public IActionResult MedicoDelete(int id)
        {
            try{
                _medicosRep.DeleteMedico(id);
                return Ok("Medico eliminado correctamente");
            }
            catch{
                return BadRequest("Error al eliminar Medico");
            }
        }
    }
}