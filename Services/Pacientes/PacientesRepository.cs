
using Gestion_de_citas.Data;
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Pacientes
{
    public class PacientesRepository : IPacientesRepository
    {
        private readonly BaseContext _baseContext;
        public PacientesRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public void AddPaciente(Paciente paciente)
        {
            _baseContext.Add(paciente);
            _baseContext.SaveChanges();
        }

        public void DeletePaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public Paciente GetPacienteById(int id)
        {
           return _baseContext.Pacientes.FirstOrDefault(p => p.Id == id);

        }

        public IEnumerable<Paciente> GetPacientes()
        {
            return _baseContext.Pacientes.ToList();
        }

        public void UpdatePaciente(int id, Paciente paciente)
        {
            var pacienteUpdate = _baseContext.Pacientes.FirstOrDefault(p => p.Id ==id);
            
            pacienteUpdate.Nombres = paciente.Nombres;
            pacienteUpdate.Apellidos = paciente.Apellidos;
            pacienteUpdate.FechaNacimiento = paciente.FechaNacimiento;
            pacienteUpdate.Correo = paciente.Correo;
            pacienteUpdate.Telefono = paciente.Telefono;
            pacienteUpdate.Direccion = paciente.Direccion;

            _baseContext.Update(pacienteUpdate);
            _baseContext.SaveChanges();
        }
    }
}