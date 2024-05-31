
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Services.Citas
{
    public interface ICitasRepository
    {
        IEnumerable<Cita> GetCitas();
        Cita GetCitaById(int id);
        void AddCita(Cita cita);
        void UpdateCita(int id, Cita cita);
        void DeleteCita(int id);
    }
}