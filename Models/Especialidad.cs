

namespace Gestion_de_citas.Models
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public enum Estado { Activo, Inactivo}
    }
}