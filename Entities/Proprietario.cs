using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public class Proprietario
    {//Não entendi o porque dessa key. Sem ela o programa estava dando erro.

        [Key]

        public int IdProprietario { get; set; }
        public string NomeProprietario { get; set; }
        public string CpfProprietario { get; set; }
        public string EmailProprietario { get; set; }
        public string TelefoneProprietario { get; set; }
        public string NascimentoProprietario { get; set; }
        public string EnderecoProprietario { get; set; }
    }
}