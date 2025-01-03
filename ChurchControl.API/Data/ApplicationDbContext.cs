using ChurchControl.API.Data;
using Microsoft.EntityFrameworkCore;

namespace ChurchControl.API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Membro> Membros { get; set; }
        public DbSet<Visitante> Visitantes { get; set; }
        public DbSet<Meds> Meds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Membro>().ToTable("Membros");
            modelBuilder.Entity<Visitante>().ToTable("Visitantes");
            modelBuilder.Entity<Meds>().ToTable("Meds");
        }
    }
}
