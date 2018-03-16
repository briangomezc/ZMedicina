using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence
{
    public static class DbInitializer
    {
        public static void Initialize(PacienteDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

