using Microsoft.EntityFrameworkCore;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Context






{
    //O DbContext é uma herança que vem do pacote EntityFrameworkCore
    public class AgendaContext : DbContext
    {

        //este construtor recebe a conexão do banco e passa para a nossa base/DbContext. o Context faz a ligação com o banco de dados.
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        // a entidade neste caso é tanto uma classe quanto uma tabela no banco de dados.
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }

    }
}