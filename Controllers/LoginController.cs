using API.Context;
using API.Entities;
using API.Dto;
using API.Services;
using Microsoft.AspNetCore.Mvc;



namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly AgendaContext _context;
        public LoginController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginDto login)
        {
            try
            {
                var usuario = _context.Login(login);
                var tm = new TokenGenerator();
                var token = tm.Generate(usuario);
                return Ok(new { token = token });
            }
            catch (Exception)
            {
                return Unauthorized(new { message = "Incorrect e-mail or password" });
            }
        }
    }
}