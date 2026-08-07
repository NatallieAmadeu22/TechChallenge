using System.ComponentModel.DataAnnotations;

namespace TechChallenge;

public class Aluno
{
    public int Id { get; set; } // Primary Key
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }
}
