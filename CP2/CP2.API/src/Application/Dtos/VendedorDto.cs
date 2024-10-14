using System.ComponentModel.DataAnnotations;

namespace CP2.API.Application.Dtos
{
    public class VendedorDto
    {
        [Required(ErrorMessage = $"Campo {nameof(Nome)} é obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Campo nome deve ter no minimo 3 caracteres")]
        public string Nome { get; set; } = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(Email)} é obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Campo email deve ter no minimo 3 caracteres")]
        public string Email { get; set; } = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(Telefone)} é obrigatorio")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Campo telefone deve ter no minimo 3 caracteres")]
        [Phone(ErrorMessage = "Campo telefone deve ser um telefone valido")]
        public string Telefone { get; set; } = string.Empty;
        
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; } 
        
        [Required(ErrorMessage = $"Campo {nameof(Endereco)} é obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Campo endereco deve ter no minimo 3 caracteres")]
        public string Endereco { get; set; } = string.Empty;
        
        [DataType(DataType.Date)]
        public DateTime DataContratacao { get; set; }
        
        public decimal ComissaoPercentual { get; set; }
        
        public decimal MetaMensal { get; set; }

        [DataType(DataType.Date)]
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
