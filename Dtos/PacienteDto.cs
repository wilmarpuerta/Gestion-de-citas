using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_de_citas.Dtos
{
    public class PacienteDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }

        public PacienteDto(int id, string name, string Apellidos, DateTime FechaNacimiento, string Correo, string Telefono, string Direccion, string Estado){
            this.Id = id;
            this.Nombres = name;
            this.Apellidos = Apellidos;
            this.FechaNacimiento = FechaNacimiento;
            this.Correo = Correo;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
            this.Estado = Estado;
        }
    }
}