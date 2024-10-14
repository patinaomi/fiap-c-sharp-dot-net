﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.API.Domain.Entities
{
    [Table("tb_vendedor")]
    public class VendedorEntity
    {
        [Key]
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Telefone { get; set; }
        
        public DateTime DataNascimento { get; set; }
        
        public string Endereco { get; set; }
        
        public DateTime DataContratacao { get; set; }
        
        [Column(TypeName = "DECIMAL(6, 2)")] 
        public decimal ComissaoPercentual { get; set; }
        
        [Column(TypeName = "DECIMAL(10, 2)")] 
        public decimal MetaMensal { get; set; }
        
        public DateTime CriadoEm { get; set; }
        
    }
}
