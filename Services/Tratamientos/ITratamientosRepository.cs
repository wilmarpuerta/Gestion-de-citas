
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Tratamientos
{
    public interface ITratamientosRepository
    {
        IEnumerable<Tratamiento> GetTratamientos();
        Tratamiento GetTratamientoById(int id);
        void AddTratamiento(Tratamiento Tratamiento);
        void UpdateTratamiento(int id, Tratamiento Tratamiento);
        void DeleteTratamiento(int id);
    }
}