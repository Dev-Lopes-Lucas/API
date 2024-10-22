using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProprietarioController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ProprietarioController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateProprietario(Proprietario proprietario)
        {
            _context.Add(proprietario);
            _context.SaveChanges();
            return Ok(proprietario);

        }

        [HttpGet("{idProprietario}")]
        public IActionResult ObterPorIdProprietario(int idProprietario)
        {

            var proprietario = _context.Contatos.Find(idProprietario);

            if (proprietario == null)
                return NotFound();

            return Ok(proprietario);
        }


        [HttpGet("ObterPorNomeProprietario")]
        public IActionResult ObterPorNomeProprietario(string nomeProprietario)
        {

            var proprietarios = _context.Proprietarios.Where(x => x.NomeProprietario.Contains(nomeProprietario));



            return Ok(proprietarios);
        }


        [HttpPut("{idProprietario}")]
        public IActionResult Atualizar(int idProprietario, Proprietario proprietario)
        {

            var proprietarioBanco = _context.Proprietarios.Find(idProprietario);

            if (proprietarioBanco == null)
                return NotFound();

            proprietarioBanco.NomeProprietario = proprietario.NomeProprietario;
            proprietarioBanco.CpfProprietario = proprietario.CpfProprietario;
            proprietarioBanco.EmailProprietario = proprietario.EmailProprietario;
            proprietarioBanco.TelefoneProprietario = proprietario.TelefoneProprietario;
            proprietarioBanco.NascimentoProprietario = proprietario.NascimentoProprietario;
            proprietarioBanco.EnderecoProprietario = proprietario.EnderecoProprietario;


            _context.Proprietarios.Update(proprietarioBanco);
            _context.SaveChanges();

            return Ok(proprietarioBanco);

        }

        [HttpDelete("{idProprietario}")]
        public IActionResult Deletar(int idProprietario)
        {

            var proprietarioBanco = _context.Proprietarios.Find(idProprietario);

            if (proprietarioBanco == null)
                return NotFound();

            _context.Proprietarios.Remove(proprietarioBanco);
            _context.SaveChanges();

            return NoContent();

        }
    }
}