using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("cidade")]
    public class CidadeController : ControllerBase
    {
        private readonly AgendaContext _context;
        public CidadeController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Cidade cidade)
        {
            _context.Add(cidade);
            _context.SaveChanges();
            return Ok(cidade);

        }

        [HttpGet("{idCidade}")]
        public IActionResult ObterPorId(int idCidade)
        {

            var cidade = _context.Cidades.Find(idCidade);

            if (cidade == null)
                return NotFound();

            return Ok(cidade);
        }


        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nomeCidade)
        {

            var cidades = _context.Cidades.Where(x => x.NomeCidade.Contains(nomeCidade));



            return Ok(cidades);
        }


        [HttpPut("{idCidade}")]
        public IActionResult Atualizar(int idCidade, Cidade cidade)
        {

            var cidadeBanco = _context.Cidades.Find(idCidade);

            if (cidadeBanco == null)
                return NotFound();

            cidadeBanco.IdCidade = cidade.IdCidade;
            cidadeBanco.NomeCidade = cidade.NomeCidade;
            cidadeBanco.Espacos = cidade.Espacos;
            cidadeBanco.Estado = cidade.Estado;



            _context.Cidades.Update(cidadeBanco);
            _context.SaveChanges();

            return Ok(cidadeBanco);

        }

        [HttpDelete("{idCidade}")]
        public IActionResult Deletar(int idCidade)
        {

            var cidadeBanco = _context.Cidades.Find(idCidade);

            if (cidadeBanco == null)
                return NotFound();

            _context.Cidades.Remove(cidadeBanco);
            _context.SaveChanges();

            return NoContent();

        }
    }
}