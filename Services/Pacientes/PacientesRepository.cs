
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
            paciente.Estado = "Activo";
            _baseContext.Add(paciente);
            _baseContext.SaveChanges();
        }
        

        public void DeletePaciente(int id)
        {
            var pacienteDelete = _baseContext.Pacientes.FirstOrDefault(p => p.Id == id);
            pacienteDelete.Estado = "Inactivo";
            _baseContext.Update(pacienteDelete);
            _baseContext.SaveChanges();
        }

        public Paciente GetPacienteById(int id)
        {
           var paciente = _baseContext.Pacientes.FirstOrDefault(p => p.Id == id);
           return  paciente;
        }

        public IEnumerable<Paciente> GetPacientes()
        {
            var pacientes = _baseContext.Pacientes.ToList();
            return pacientes;
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
            pacienteUpdate.Estado = paciente.Estado;
            
            _baseContext.Update(pacienteUpdate);
            _baseContext.SaveChanges();
        }
    }
}