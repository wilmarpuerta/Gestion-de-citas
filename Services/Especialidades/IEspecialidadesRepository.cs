
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Especialidades
{
    public interface IEspecialidadesRepository
    {
        IEnumerable<Especialidad> GetEspecialidades();
        Especialidad GetEspecialidadById(int id);
        void AddEspecialidad(Especialidad especialidad);
        void UpdateEspecialidad(int id, Especialidad especialidad);
        void DeleteEspecialidad(int id);
    }
}