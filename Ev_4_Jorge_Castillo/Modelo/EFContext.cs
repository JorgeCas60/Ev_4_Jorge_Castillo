using Microsoft.EntityFrameworkCore;

namespace Ev_4_Jorge_Castillo.Modelo
{
    public class EFContext : DbContext
    {
      
        private const string ConnectionString = "server=localhost;port=3306;database=ev4_libros;user=root;password=;Connect Timeout=5;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 11)));
        }

       
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Libro>().HasKey(i => i.Id);
            modelBuilder.Entity<Editorial>().HasKey(j => j.Id);

          
            modelBuilder.Entity<Libro>()
                .HasOne<Editorial>(s => s.Editorial)
                .WithMany(g => g.Libros)
                .HasForeignKey(c => c.IdEditorial);

       
            modelBuilder.Entity<Libro>().Property(s => s.IdEditorial).IsRequired();
            modelBuilder.Entity<Libro>().Property(s => s.Nombre).IsRequired();
            modelBuilder.Entity<Libro>().Property(s => s.NroSerie).IsRequired();

            modelBuilder.Entity<Editorial>().Property(s => s.Nombre).IsRequired();
            modelBuilder.Entity<Editorial>().Property(s => s.FechaCreacion)
                .HasDefaultValue(DateTime.Now) 
                .IsRequired();
            modelBuilder.Entity<Editorial>().Property(s => s.Run).IsRequired();
        }
    }
}
