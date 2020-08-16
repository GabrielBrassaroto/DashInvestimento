using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DashInvestimentos.Models;

namespace DashInvestimentos.Data
{
    public class DashInvestimentosContext : DbContext
    {
        public DashInvestimentosContext (DbContextOptions<DashInvestimentosContext> options)
            : base(options)
        {
        }

        public DbSet<DashInvestimentos.Models.Movimentacao> Movimentacao { get; set; }
    }
}
