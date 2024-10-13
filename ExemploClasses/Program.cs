namespace ExemploClasses;

class Program
{
   
    
    static void Main(string[] args)
    {
        var c1 = new Carro(1950, "Volkswagen", "Fusca");
        var c2 = new Carro();
        c2.Ano = 2024;
        c2.Modelo = "Gol";
        c2.Fabricante = "Volkswagen";
        
        
        //Console.WriteLine(c1.Ano + " " + c1.Modelo);
        //Console.WriteLine(c2.Ano + " " + c2.Modelo);
        
        c1.Detalhe();
        c2.Detalhe();
    }
}