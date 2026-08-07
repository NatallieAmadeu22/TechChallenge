

using System.ComponentModel.DataAnnotations;

namespace TechChallenge;

public class RegisterViewModel
{
    [Required] public string Nome { get; set; } = string.Empty;
    [Required][EmailAddress] public string Email { get; set; } = string.Empty;
    [Required][DataType(DataType.Password)] public string Senha { get; set; } = string.Empty;
    [Compare("Senha")] public string ConfirmarSenha { get; set; } = string.Empty;
    [Required] public string Role { get; set; } = string.Empty; // Aluno ou Professor
}


