using System.ComponentModel.DataAnnotations;
namespace API.Entities
{
    public class Cidade
    {
        [Key]

        public int IdCidade { get; set; }

        public string? NomeCidade { get; set; }

        public virtual List<Espaco>? Espacos { get; set; }

        public string? Estado { get; set; }
    }
}