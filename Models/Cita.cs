

namespace Gestion_de_citas.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

    }
}