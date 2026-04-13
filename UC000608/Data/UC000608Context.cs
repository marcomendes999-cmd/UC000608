using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UC000608.Models;

namespace UC000608.Data
{
    public class UC000608Context : DbContext
    {
        public UC000608Context (DbContextOptions<UC000608Context> options)
            : base(options)
        {
        }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Membro> Membros { get; set; }
        public DbSet<Treinador> Treinadores { get; set; }
        public DbSet<UC000608.Models.Pessoa> Pessoa { get; set; } = default!;

    }
}
