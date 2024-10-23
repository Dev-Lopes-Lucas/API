using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Usuario
    {
        [Key]
        //UserId
        public int IdUsuario { get; set; }
        //Name
        public string? Nome { get; set; }
        //Email
        public string? Email { get; set; }
        //Password
        public string? Senha { get; set; }
        //UserType
        public string? Tipo { get; set; }
        //Booking
        public List<Reserva>? Reservas { get; set; }
    }
}