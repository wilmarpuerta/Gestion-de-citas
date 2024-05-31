
using Gestion_de_citas.Data;
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Medicos
{
    public class MedicosRepository : IMedicosRepository
    {
        private readonly BaseContext _baseContext;
        public MedicosRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public void AddMedico(Medico medico)
        {
            medico.Estado = "Activo";
            _baseContext.Add(medico);
            _baseContext.SaveChanges();
        }
        

        public void DeleteMedico(int id)
        {
            var medicoDelete = _baseContext.Medicos.FirstOrDefault(p => p.Id == id);
            medicoDelete.Estado = "Inactivo";
            _baseContext.Update(medicoDelete);
            _baseContext.SaveChanges();
        }

        public Medico GetMedicoById(int id)
        {
           var medico = _baseContext.Medicos.FirstOrDefault(p => p.Id == id);
           return  medico;
        }

        public IEnumerable<Medico> GetMedicos()
        {
            var medicos = _baseContext.Medicos.ToList();
            return medicos;
        }

        public void UpdateMedico(int id, Medico medico)
        {
            var medicoUpdate = _baseContext.Medicos.FirstOrDefault(p => p.Id ==id);

            medicoUpdate.NombreCompleto = medico.NombreCompleto;
            medicoUpdate.Especialidad = medico.Especialidad;
            medicoUpdate.Correo = medico.Correo;
            medicoUpdate.Telefono = medico.Telefono;
            medicoUpdate.Estado = medico.Estado;
            
            _baseContext.Update(medicoUpdate);
            _baseContext.SaveChanges();
        }
    }
}