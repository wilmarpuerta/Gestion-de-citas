
using Gestion_de_citas.Models;
using Gestion_de_citas.Services.Especialidades;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_de_citas.Controllers.Especialidades
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspecialidadesController : ControllerBase
    {
        private readonly IEspecialidadesRepository _especialidadesRep;

        public EspecialidadesController(IEspecialidadesRepository especialidadesRep)
        {
            _especialidadesRep = especialidadesRep;
        }

        [HttpGet("lista")]
        public IEnumerable<Especialidad> GetEspecialidades()
        {
            try
            {
                return _especialidadesRep.GetEspecialidades();
            }
            catch
            {
                return (IEnumerable<Especialidad>)BadRequest("Error al traer las especialidades");
            }
        }

        [HttpGet("lista/{id}")]
        public Especialidad GetEspecialidadById(int id)
        {
            var especialidad = _especialidadesRep.GetEspecialidadById(id);

            if (!ModelState.IsValid)
            {
                NotFound("Error la especialidad no ha sido encontrado");
            }

            return especialidad;
        }
    }
}