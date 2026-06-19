using Microsoft.EntityFrameworkCore;
using EnergyMonitor.Models;
using System.Collections.Generic;

namespace EnergyMonitor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<ConsumoEnergia> Consumos { get; set; }
        public DbSet<AlertaConsumo> Alertas { get; set; }
        public DbSet<AcaoAutomatica> Acoes { get; set; }
    }
}
