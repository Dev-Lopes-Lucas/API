using System.ComponentModel.DataAnnotations;
namespace API.Entities
{

    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int QuantidadeUsuario { get; set; }
        public int IdUsuario { get; set; }
        public int IdEspaco { get; set; }
        public Usuario? Usuario { get; set; }

    }
}