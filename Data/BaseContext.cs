
using Microsoft.EntityFrameworkCore;
using Gestion_de_citas.Models;

namespace Gestion_de_citas.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<Cita> Citas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
    }
}