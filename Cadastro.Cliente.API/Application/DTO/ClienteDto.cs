using System.ComponentModel.DataAnnotations;

namespace Cadastro.Cliente.API.Application.DTO;

public record ClienteDto(
    
    [Required(ErrorMessage = $"O campo {nameof(Nome)} é obrigatório.")]
    [StringLength(150, MinimumLength = 3, ErrorMessage = "Campo deve ter no mínimo 3 caracteres")]
    string Nome,
    
    [Required(ErrorMessage = $"O campo {nameof(Idade)} é obrigatório.")]
    [Range(1, 120, ErrorMessage = "Idade deve ser entre 1 e 120 anos")]
    int Idade, 
    
    [Required(ErrorMessage = $"O campo {nameof(Email)} é obrigatório.")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    string Email);