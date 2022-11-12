using Backend.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Conectando.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Persona> Persona { get; set; }
        public DbSet<Antecedente> Antecedentes { get; set; }
        public DbSet<Asistencia> Asistencias{ get; set; }
        public DbSet<Barrio> Barrios { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Division> Divisiones { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<estadoInscripcion> EstadoInscripciones { get; set; }
        public DbSet<Estudiante> Estudiantes{ get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Localidad> Localidades{ get; set; }
        public DbSet<Materia> Materias{ get; set; }
        public DbSet<Parentesco> Parentescos { get; set; }
        public DbSet<Patologia> Patologias{ get; set; }
        public DbSet<Provincia> Provincias{ get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Usuario>  Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Collle;Integrated Security=True");


    }

}
