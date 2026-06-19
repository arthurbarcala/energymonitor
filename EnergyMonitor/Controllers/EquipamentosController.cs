using EnergyMonitor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnergyMonitor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipamentosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EquipamentosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos(
            int page = 1,
            int pageSize = 10)
        {
            var equipamentos = await _context.Equipamentos
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(equipamentos);
        }

        [HttpGet("desligados")]
        public async Task<IActionResult> GetDesligados()
        {
            var desligados = await _context.Equipamentos
                .Where(x => x.StatusEquipamento == "Desligado")
                .ToListAsync();

            return Ok(desligados);
        }
    }
}