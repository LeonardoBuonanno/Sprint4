using Microsoft.AspNetCore.Mvc;
using Sprint4.Models;

namespace Sprint4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] User usuario)
        {
            if (usuario.NomeUsuario == "admin" && usuario.Senha == "12345")
            {
                return Ok();
            }

            return Unauthorized();
        }
    }
}
