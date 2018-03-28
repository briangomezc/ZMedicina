using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using Service;
using System;

namespace Persistence
{
    public class PacienteDbContext : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Medico> Medico { get; set; }

        public DbSet<pacienteMedico> pacienteMedico { get; set; }

        public DbSet<Historial> Historial { get; set; }

        public DbSet<Cita> Cita { get; set; }

        public PacienteDbContext(DbContextOptions<PacienteDbContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<pacienteMedico>().HasKey(sc => new { sc.PacienteID, sc.MedicoID });

            modelBuilder.Entity<Historial>().HasKey(sc => new { sc.PacienteID, sc.MedicoID });

            modelBuilder.Entity<Cita>().ToTable("Citas"); 
        }
    }
}
