using EnergyMonitor.Data;
using EnergyMonitor.Models;
using EnergyMonitor.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnergyMonitor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsumosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConsumosController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> RegistrarConsumo(
            ConsumoCreateViewModel model)
        {
            var consumo = new ConsumoEnergia
            {
                IdEquipamento = model.IdEquipamento,
                ConsumoKwh = model.ConsumoKwh,
                DataRegistro = DateTime.Now
            };

            _context.Consumos.Add(consumo);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                mensagem = "Consumo registrado com sucesso"
            });
        }
    }
}