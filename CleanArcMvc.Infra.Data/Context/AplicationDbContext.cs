using CleanArcMvc.Domain.Models;
using CleanArcMvc.Infra.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Infra.Data.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base (options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        // DbSet <Model mapeada>   Nome da tabela no banco

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            
            //Verifica e faz um reflection para ler os arquivos para não precisar instanciar
            builder.ApplyConfigurationsFromAssembly(typeof(AplicationDbContext).Assembly);

            //Caso não fizesse uma va
            //builder.ApplyConfiguration(new CategoryConfiguration());
        }

    }
}
