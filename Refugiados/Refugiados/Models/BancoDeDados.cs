using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Refugiados.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Voluntariado> Voluntariados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Refugiados;integrated security=true");
        }

    }
}
