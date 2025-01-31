using CapaDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace CapaDatos
{
    public class AppDbContext : DbContext
    {
        //Aqui pasamos las opciones de configuracion de la base de datos. Mediante el constructor principal
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        //Aqui se declaran las tablas que se van a crear en la base de datos.
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Consultas> Consultas { get; set; }
        public DbSet<HistorialConsultas> HistorialConsultas { get; set; }
        public DbSet<Diagnosticos> Diagnosticos { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Tratamientos> Tratamientos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Paciente -> Consultas (1 a muchos)
            modelBuilder.Entity<Consultas>()
                .HasOne(c => c.Paciente)
                .WithMany(p => p.Consulta) // Relación: Paciente tiene muchas consultas
                .HasForeignKey(c => c.idPaciente)
                .OnDelete(DeleteBehavior.Cascade); // Si eliminás el paciente, se borran sus consultas.

            // Consultas -> Pagos (1 a muchos)
            modelBuilder.Entity<Pagos>()
                .HasOne(p => p.Consulta)
                .WithMany(c => c.Pagos) // Relación: Una consulta tiene muchos pagos
                .HasForeignKey(p => p.IdConsulta)
                .OnDelete(DeleteBehavior.Cascade);

            // Consultas -> Diagnósticos (1 a 1)
            modelBuilder.Entity<Diagnosticos>()
                 .HasOne(d => d.Consulta)
                 .WithMany(c => c.Diagnosticos) // Relación: Una consulta tiene muchos diagnósticos
                 .HasForeignKey(d => d.IdConsulta);

            // Consultas -> Tratamientos (1 a muchos)
            modelBuilder.Entity<Tratamientos>()
                .HasOne(t => t.Paciente)  // Un Tratamiento tiene UN paciente
                .WithMany(p => p.Tratamientos)  // Un paciente tiene MUCHOS tratamientos
                .HasForeignKey(t => t.IdPaciente)  // Clave foránea en la tabla Tratamientos
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Tratamientos>()
                .HasOne(t => t.Consulta)  // Un Tratamiento puede estar relacionado con UNA consulta
                .WithMany(c => c.Tratamientos)  // Una consulta puede tener VARIOS tratamientos
                .HasForeignKey(t => t.IdConsulta)  // Clave foránea en la tabla Tratamientos
                .OnDelete(DeleteBehavior.Cascade);


            // Pacientes -> HistorialConsultas (1 a muchos)
            modelBuilder.Entity<HistorialConsultas>()
                .HasOne(h => h.Paciente)
                .WithMany(p => p.HistorialConsultas) // Relación: Un paciente tiene muchos registros de historial
                .HasForeignKey(h => h.IdPaciente);

            // Propiedades adicionales
            modelBuilder.Entity<Pagos>()
                .Property(p => p.FechaPago)
                .IsRequired() // Campo obligatorio
                .HasMaxLength(10); // Ejemplo de límite, aunque usarías DateTime.

            modelBuilder.Entity<Tratamientos>()
                .Property(t => t.NombreTratamiento)
                .IsRequired()
                .HasMaxLength(200);

            // Configuración global para strings (si querés limitar tamaño por defecto)
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entityType.ClrType.GetProperties()
                    .Where(p => p.PropertyType == typeof(string));

                foreach (var property in properties)
                {
                    modelBuilder.Entity(entityType.Name)
                        .Property(property.Name)
                        .HasMaxLength(255); // Máximo por defecto para strings
                }
            }

            base.OnModelCreating(modelBuilder);
        }


        //Aqui lo que hacemos es configurar la base de datos.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=CintaRoja.sqlite");
            }
        }
    }
}
