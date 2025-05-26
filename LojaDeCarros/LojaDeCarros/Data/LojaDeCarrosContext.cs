using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaDeCarros.Models;

namespace LojaDeCarros.Data
{
    public class LojaDeCarrosContext : DbContext
    {
        public LojaDeCarrosContext (DbContextOptions<LojaDeCarrosContext> options)
            : base(options)
        {
        }

        public DbSet<LojaDeCarros.Models.Carro> Carro { get; set; } = default!;

        public DbSet<LojaDeCarros.Models.Cliente>? Cliente { get; set; }

        public DbSet<LojaDeCarros.Models.Nota>? Nota { get; set; }

        public DbSet<LojaDeCarros.Models.Vendedor>? Vendedor { get; set; }
    }
}
