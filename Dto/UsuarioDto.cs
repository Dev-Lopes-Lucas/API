namespace API.Dto
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Tipo { get; set; }

    }

    public class UsuarioDtoInsert
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }

    public class LoginDto
    {
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}