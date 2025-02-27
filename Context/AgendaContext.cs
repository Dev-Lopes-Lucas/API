using Microsoft.EntityFrameworkCore;
using API.Entities;
using API.Dto;
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

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Espaco> Espacos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



        //Eu que fiz a parte de baixo.

        public UsuarioDto Login(LoginDto login)
        {
            var usuario = Usuarios.FirstOrDefault(u => u.Email == login.Email && u.Senha == login.Senha) ?? throw new Exception("Invalid email or password");
            return new UsuarioDto
            {
                IdUsuario = usuario.IdUsuario,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha,
                Tipo = usuario.Tipo
            };
        }






    }
}