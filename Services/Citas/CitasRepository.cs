
using Gestion_de_citas.Data;
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Citas
{
    public class CitasRepository : ICitasRepository
    {
        private readonly BaseContext _baseContext;
        public CitasRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public void AddCita(Cita cita)
        {
            cita.Estado = "Activo";
            _baseContext.Add(cita);
            _baseContext.SaveChanges();
        }
        

        public void DeleteCita(int id)
        {
            var citaDelete = _baseContext.Citas.FirstOrDefault(p => p.Id == id);
            citaDelete.Estado = "Inactivo";
            _baseContext.Update(citaDelete);
            _baseContext.SaveChanges();
        }

        public Cita GetCitaById(int id)
        {
           var cita = _baseContext.Citas.FirstOrDefault(p => p.Id == id);
           return  cita;
        }

        public IEnumerable<Cita> GetCitas()
        {
            var cita = _baseContext.Citas.ToList();
            return cita;
        }

        public void UpdateCita(int id, Cita cita)
        {
            var citaUpdate = _baseContext.Citas.FirstOrDefault(p => p.Id ==id);

            citaUpdate.MedicoId = cita.MedicoId;
            citaUpdate.PacienteId = cita.PacienteId;
            citaUpdate.Fecha = cita.Fecha;
            citaUpdate.Estado = cita.Estado;
            
            _baseContext.Update(citaUpdate);
            _baseContext.SaveChanges();
        }
    }
}