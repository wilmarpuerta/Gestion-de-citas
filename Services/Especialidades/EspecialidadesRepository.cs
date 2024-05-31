
using Gestion_de_citas.Data;
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Especialidades
{
    public class EspecialidadesRepository : IEspecialidadesRepository
    {
        private readonly BaseContext _baseContext;
        public EspecialidadesRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public void AddEspecialidad(Especialidad especialidad)
        {
            especialidad.Estado = "Activo";
            _baseContext.Add(especialidad);
            _baseContext.SaveChanges();
        }
        

        public void DeleteEspecialidad(int id)
        {
            var especialidadDelete = _baseContext.Especialidades.FirstOrDefault(p => p.Id == id);
            especialidadDelete.Estado = "Inactivo";
            _baseContext.Update(especialidadDelete);
            _baseContext.SaveChanges();
        }

        public Especialidad GetEspecialidadById(int id)
        {
           var especialidad = _baseContext.Especialidades.FirstOrDefault(p => p.Id == id);
           return  especialidad;
        }

        public IEnumerable<Especialidad> GetEspecialidades()
        {
            var especialidades = _baseContext.Especialidades.ToList();
            return especialidades;
        }

        public void UpdateEspecialidad(int id, Especialidad especialidad)
        {
            var especialidadUpdate = _baseContext.Especialidades.FirstOrDefault(p => p.Id ==id);

            especialidadUpdate.Nombre = especialidad.Nombre;
            especialidadUpdate.Descripcion = especialidad.Descripcion;
            especialidadUpdate.Estado = especialidad.Estado;
            
            _baseContext.Update(especialidadUpdate);
            _baseContext.SaveChanges();
        }
    }
}