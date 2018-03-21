using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;

namespace Persistence
{
    public class PacienteDbContext : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Medico> Medico { get; set; }

        public PacienteDbContext(DbContextOptions<PacienteDbContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Paciente>()
            .HasOne(p => p.Medico)
            .WithMany(b => b.Pacientes);
        }
    }
}
