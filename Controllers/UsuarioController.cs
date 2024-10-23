using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly AgendaContext _context;
        public UsuarioController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);

        }

        [HttpGet("{idUsuario}")]
        public IActionResult ObterPorId(int idUsuario)
        {

            var usuario = _context.Usuarios.Find(idUsuario);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }


        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {

            var usuarios = _context.Usuarios.Where(x => x.Nome.Contains(nome));



            return Ok(usuarios);
        }


        [HttpPut("{idUsuario}")]
        public IActionResult Atualizar(int idUsuario, Usuario usuario)
        {

            var usuarioBanco = _context.Usuarios.Find(idUsuario);

            if (usuarioBanco == null)
                return NotFound();


            usuarioBanco.Nome = usuario.Nome;
            usuarioBanco.Email = usuario.Email;
            usuarioBanco.Senha = usuario.Senha;
            usuarioBanco.Tipo = usuario.Tipo;
            usuarioBanco.Reservas = usuario.Reservas;


            _context.Usuarios.Update(usuarioBanco);
            _context.SaveChanges();

            return Ok(usuarioBanco);

        }

        [HttpDelete("{idUsuario}")]
        public IActionResult Deletar(int idUsuario)
        {

            var usuarioBanco = _context.Usuarios.Find(idUsuario);

            if (usuarioBanco == null)
                return NotFound();

            _context.Usuarios.Remove(usuarioBanco);
            _context.SaveChanges();

            return NoContent();

        }
    }
}