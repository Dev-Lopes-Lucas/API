using System.ComponentModel.DataAnnotations;
namespace API.Entities
{
    public class Espaco
    {
        [Key]
        public int IdEspaco { get; set; }

        public string? NomeEspaco { get; set; }

        public string? Endereco { get; set; }

        //public int CityId { get; set; }

        public Cidade? Cidade { get; set; }

        //public virtual List<Room>? Rooms { get; set; }

        public string? Image { get; set; }
    }
}