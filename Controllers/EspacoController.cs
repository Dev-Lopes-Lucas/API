using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    public class EspacoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public EspacoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Espaco espaco)
        {
            _context.Add(espaco);
            _context.SaveChanges();
            return Ok(espaco);

        }

        [HttpGet("{idEspaco}")]
        public IActionResult ObterPorId(int idEspaco)
        {

            var espaco = _context.Espacos.Find(idEspaco);

            if (espaco == null)
                return NotFound();

            return Ok(espaco);
        }


        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nomeEspaco)
        {

            var espacos = _context.Espacos.Where(x => x.NomeEspaco.Contains(nomeEspaco));



            return Ok(espacos);
        }


        [HttpPut("{idEspaco}")]
        public IActionResult Atualizar(int idEspaco, Espaco espaco)
        {

            var espacoBanco = _context.Espacos.Find(idEspaco);

            if (espacoBanco == null)
                return NotFound();

            espacoBanco.IdEspaco = espaco.IdEspaco;
            espacoBanco.NomeEspaco = espaco.NomeEspaco;
            espacoBanco.Endereco = espaco.Endereco;
            espacoBanco.IdCidade = espaco.IdCidade;
            espacoBanco.Cidade = espaco.Cidade;



            _context.Espacos.Update(espacoBanco);
            _context.SaveChanges();

            return Ok(espacoBanco);

        }

        [HttpDelete("{idEspaco}")]
        public IActionResult Deletar(int idEspaco)
        {

            var espacoBanco = _context.Espacos.Find(idEspaco);

            if (espacoBanco == null)
                return NotFound();

            _context.Espacos.Remove(espacoBanco);
            _context.SaveChanges();

            return NoContent();

        }
    }
}