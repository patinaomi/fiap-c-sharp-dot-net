﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.API.Domain.Entities
{
    [Table("tb_fornecedor")]
    public class FornecedorEntity
    {

        [Key]
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Cnpj { get; set; }
        
        public string Telefone { get; set; }
        
        public string Email { get; set; }
        
        public DateTime CriadoEm { get; set; }
    }
}
