namespace ExemploClasses;

public abstract class Veiculo
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }

    public Veiculo()
    {
        
    }

    public Veiculo(string fabricante, string modelo)
    {
        Fabricante = "Hyundai";
        Modelo = modelo;
    }

    public virtual void Detalhe()
    {
        Console.WriteLine($"Veículo: {Modelo} - {Fabricante}");
    }
}