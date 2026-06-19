using EnergyMonitor.Data;
using EnergyMonitor.Models;
using EnergyMonitor.ViewModels;

namespace EnergyMonitor.Services
{
    public class ConsumoService
    {
        private readonly AppDbContext _context;

        public ConsumoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task RegistrarConsumo(ConsumoCreateViewModel model)
        {
            var consumo = new ConsumoEnergia
            {
                IdEquipamento = model.IdEquipamento,
                ConsumoKwh = model.ConsumoKwh,
                DataRegistro = DateTime.Now
            };

            _context.Consumos.Add(consumo);

            await _context.SaveChangesAsync();
        }
    }
}