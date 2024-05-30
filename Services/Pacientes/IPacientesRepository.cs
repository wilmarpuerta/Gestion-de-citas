
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Pacientes
{
    public interface IPacientesRepository
    {
        IEnumerable<Paciente> GetPacientes();
        Paciente GetPacienteById(int id);
        void AddPaciente(Paciente paciente);
        void UpdatePaciente(int id, Paciente paciente);
        void DeletePaciente(Paciente paciente);
    }
}