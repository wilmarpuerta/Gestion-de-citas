
using Gestion_de_citas.Data;
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Tratamientos
{
    public class TratamientosRepository : ITratamientosRepository
    {
        private readonly BaseContext _baseContext;
        public TratamientosRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public void AddTratamiento(Tratamiento tratamiento)
        {
            tratamiento.Estado = "Activo";
            _baseContext.Add(tratamiento);
            _baseContext.SaveChanges();
        }
        

        public void DeleteTratamiento(int id)
        {
            var tratamientoDelete = _baseContext.Tratamientos.FirstOrDefault(p => p.Id == id);
            tratamientoDelete.Estado = "Inactivo";
            _baseContext.Update(tratamientoDelete);
            _baseContext.SaveChanges();
        }

        public Tratamiento GetTratamientoById(int id)
        {
           var tratamiento = _baseContext.Tratamientos.FirstOrDefault(p => p.Id == id);
           return  tratamiento;
        }

        public IEnumerable<Tratamiento> GetTratamientos()
        {
            var tratamientos = _baseContext.Tratamientos.ToList();
            return tratamientos;
        }

        public void UpdateTratamiento(int id, Tratamiento tratamiento)
        {
            var tratamientoUpdate = _baseContext.Tratamientos.FirstOrDefault(p => p.Id ==id);

            tratamientoUpdate.CitaId = tratamiento.CitaId;
            tratamientoUpdate.Descripcion = tratamiento.Descripcion;
            tratamientoUpdate.Estado = tratamiento.Estado;
            
            _baseContext.Update(tratamientoUpdate);
            _baseContext.SaveChanges();
        }
    }
}