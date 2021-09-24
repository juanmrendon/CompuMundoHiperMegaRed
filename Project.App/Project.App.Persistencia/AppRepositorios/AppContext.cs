using Microsoft.EntityFrameworkCore; 
using Project.App.Dominio; 


namespace Project.App.Persistencia

{
    public class AppContext : DbContext

    {
        public DbSet<Diagnostico> Diagnosticos {get; set;}

        public DbSet<Directivos> Directivos {get; set;}

        public DbSet<Estudiante> Estudiantes {get; set;}

        public DbSet<Instalaciones> Instalaciones {get; set;}

        public DbSet<Persona> Personas {get; set;}

        public DbSet<PersonalAseo> PersonalAseso {get; set;}

        public DbSet<Profesor> Profesores {get; set;}

        public DbSet<Salon> Salones {get; set;}

        public DbSet<Vacuna> Vacunas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured)

            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProjectData");
            }

        }
        
    }
}