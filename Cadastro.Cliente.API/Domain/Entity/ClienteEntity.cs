using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Cliente.API.Domain.Entity;

[Table("tb_cliente")]
public class ClienteEntity
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}