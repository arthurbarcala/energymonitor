using EnergyMonitor.Services;
using EnergyMonitor.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EnergyMonitor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (login.Usuario == "admin"
                && login.Senha == "123")
            {
                var token = _jwtService.GenerateToken(login.Usuario);

                return Ok(new
                {
                    token
                });
            }

            return Unauthorized();
        }
    }
}