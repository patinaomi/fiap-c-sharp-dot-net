using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

[Table("tb_aula")]
public class AulaModel
{
    public int Id { get; set; }
    [DisplayName("Campo Nome:")]
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    public string Nome { get; set; }   
    public string Turma { get; set; }
    
    
}