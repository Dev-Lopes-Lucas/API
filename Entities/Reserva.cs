using System.ComponentModel.DataAnnotations;
namespace API.Entities
{

    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int QuantidadeHospede { get; set; }
        //public int UserId { get; set; }
        //public int IdEspaco { get; set; }
        //public virtual Usuario? Usuario { get; set; }

    }
}