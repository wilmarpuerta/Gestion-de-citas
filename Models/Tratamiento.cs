

namespace Gestion_de_citas.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }
        public string CitaId { get; set; }
        public string Descripcion { get; set; }
        public enum Estado { Activo, Inactivo}
    }
}