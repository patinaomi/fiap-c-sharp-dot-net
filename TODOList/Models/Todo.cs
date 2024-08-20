namespace TODOList.Models;

public class Todo
{
    public int Id { get; set; }
    public string Tarefa { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public bool feito { get; set; } = false;

}