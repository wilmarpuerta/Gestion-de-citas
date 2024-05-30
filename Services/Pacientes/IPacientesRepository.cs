
using Gestion_de_citas.Dtos;
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Pacientes
{
    public interface IPacientesRepository
    {
        IEnumerable<PacienteDto> GetPacientes();
        PacienteDto GetPacienteById(int id);
        void AddPaciente(PacienteDto paciente);
        void UpdatePaciente(int id, Paciente paciente);
        void DeletePaciente(Paciente paciente);
    }
}