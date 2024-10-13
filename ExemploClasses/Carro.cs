namespace ExemploClasses;

class Carro : Veiculo
{
    public int Ano { get; set; }
        
    
        
    // Construtor com parâmetro
    public Carro(int ano, string fabricante, string modelo) : base(fabricante, modelo)
    {
        Ano = ano;
        Modelo = "Fusca";
    }

    public Carro()
    {
        
    }
        
    // Métodos
    public override void Detalhe()
    {
        base.Detalhe();
        Console.WriteLine($"Ano do Carro: {Ano}");
    }
}