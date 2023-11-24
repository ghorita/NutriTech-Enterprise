using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GlobalSolution02.Models;

namespace GlobalSolution02.Data
{
    public class GlobalSolution02Context : DbContext
    {
        public GlobalSolution02Context (DbContextOptions<GlobalSolution02Context> options)
            : base(options)
        {
        }

        public DbSet<GlobalSolution02.Models.Calculadora> Calculadora { get; set; } = default!;
    }
}
