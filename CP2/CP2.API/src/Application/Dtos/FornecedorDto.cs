using System.ComponentModel.DataAnnotations;

namespace CP2.API.Application.Dtos
{
    public class FornecedorDto
    {
        
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Campo nome deve ter no minimo 3 caracteres")]
        public string Nome { get; set; }  = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(Cnpj)} é obrigatorio")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Campo cnpj deve ter no minimo 5 caracteres")]
        public string Cnpj { get; set; } = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(Telefone)} é obrigatorio")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Campo telefone deve ter no minimo 3 caracteres")]
        [Phone(ErrorMessage = "Campo telefone deve ser um telefone valido")]
        public string Telefone { get; set; } = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(Email)} é obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Campo email deve ter no minimo 3 caracteres")]
        [EmailAddress(ErrorMessage = "Campo email deve ser um email valido")]
        public string Email { get; set; } = string.Empty;
        
        [DataType(DataType.Date)]
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
