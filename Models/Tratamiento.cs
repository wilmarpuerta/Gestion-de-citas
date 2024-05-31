

namespace Gestion_de_citas.Models
{
    public class Tratamiento
    {
        public int Id { get; set; }
        public int CitaId { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}