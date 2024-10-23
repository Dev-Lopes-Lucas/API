using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;


namespace API.Dto
{
    public class EspacoDto
    {
        public int IdEspaco { get; set; }

        public string? NomeEspaco { get; set; }

        public string? Endereco { get; set; }

        public int IdCidade { get; set; }

        public Cidade? Cidade { get; set; }


    }
}