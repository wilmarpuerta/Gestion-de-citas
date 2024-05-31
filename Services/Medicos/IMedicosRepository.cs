
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Medicos
{
    public interface IMedicosRepository
    {
        IEnumerable<Medico> GetMedicos();
        Medico GetMedicoById(int id);
        void AddMedico(Medico medico);
        void UpdateMedico(int id, Medico medico);
        void DeleteMedico(int id);
    }
}