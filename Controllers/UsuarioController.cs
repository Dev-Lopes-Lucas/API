using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace ApiSwagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString(),


            };
            return Ok(obj);
        }
        //O HTTPGET é o caminho para chegar no resultador do GET.
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo";
            return Ok(new { mensagem });
        }

    }
}