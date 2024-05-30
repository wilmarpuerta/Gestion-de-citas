

namespace Gestion_de_citas.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public int Especialidad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public enum Estado { Activo, Inactivo}
    }
}