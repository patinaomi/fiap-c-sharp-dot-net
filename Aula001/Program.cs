namespace Aula001;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tipos");
        int numeroInteiro = 1;
        float numeroDecimal = 25.324234f;
        double numeroDecimalPreciso = 25.4234234234234233242;

        string texto = "Isso é um texto";
        char caracter = 'a';

        List<string> lista = new List<string> { "nome", "telefone" };
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
        if (texto != "Não é um texto") Console.WriteLine(texto);
        else Console.WriteLine("que texto");

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        foreach (string str in lista)
        {
            Console.WriteLine(str);
        }

    }
}