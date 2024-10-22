using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Contato
    {
        //Não entendi o porque dessa key. Sem ela o programa estava dando erro.
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}