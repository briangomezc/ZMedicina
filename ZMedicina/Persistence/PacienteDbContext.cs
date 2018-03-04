using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace Persistence
{
    public class PacienteDbContext : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }

        public PacienteDbContext(DbContextOptions<PacienteDbContext> options) : base(options)
        {

        }
    }
}
