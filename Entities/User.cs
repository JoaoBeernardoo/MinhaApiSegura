namespace MinhaApiSegura.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    }
}