
using Gestion_de_citas.Data;
using Gestion_de_citas.Dtos;
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
        public void AddPaciente(PacienteDto paciente)
        {
            paciente.Estado = "Activo";
            _baseContext.Add(paciente);
            _baseContext.SaveChanges();
        }
        

        public void DeletePaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public PacienteDto GetPacienteById(int id)
        {
           var paciente = _baseContext.Pacientes.FirstOrDefault(p => p.Id == id);
           PacienteDto pacienteDto = new PacienteDto(
            paciente.Id,
            paciente.Nombres,
            paciente.Apellidos,
            paciente.FechaNacimiento,
            paciente.Correo,
            paciente.Telefono,
            paciente.Direccion,
            paciente.Estado.ToString() 
           );
           return pacienteDto;

        }

        public IEnumerable<PacienteDto> GetPacientes()
        {
            var pacientes = _baseContext.Pacientes.ToList();
            List<PacienteDto> pacientesDto = new List<PacienteDto>();

            foreach (var paciente in pacientes)
            {
                PacienteDto pacienteDto = new PacienteDto
                (
                    paciente.Id,
                    paciente.Nombres,
                    paciente.Apellidos,
                    paciente.FechaNacimiento,
                    paciente.Correo,
                    paciente.Telefono,
                    paciente.Direccion,
                    paciente.Estado.ToString()
                );

                pacientesDto.Add(pacienteDto);
            }
            
            return pacientesDto;
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