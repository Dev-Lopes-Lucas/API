using System.ComponentModel.DataAnnotations;
namespace API.Entities
{
    public class Espaco
    {
        [Key]
        public int IdEspaco { get; set; }

        public string? NomeEspaco { get; set; }

        public string? Endereco { get; set; }

        public int IdCidade { get; set; }

        public Cidade? Cidade { get; set; }


    }
}