using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PersonaService.Models;
namespace PersonaService.Data
{
    public class PersonaDBContext : DbContext
    {
        public PersonaDBContext(DbContextOptions<PersonaDBContext> options) : base(options) { }
        public DbSet<AgregaPersona> AgregaPersonas { get; set; }
        public DbSet<FiltrarPersona> FiltrarPersonas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgregaPersona>().HasNoKey();
            modelBuilder.Entity<FiltrarPersona>().HasNoKey();
        }
    }
}
