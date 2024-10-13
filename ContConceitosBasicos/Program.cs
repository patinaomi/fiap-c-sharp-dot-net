namespace ContConceitosBasicos;

// Com instruções de nível superior, você não precisa declarar
// a classe Program nem o método Main explicitamente.

// Aqui no caso eu marquei a opção de não usar instruções de nível superior
class Program
{
    static void Main()
    {
        // Operadores de Condição
        if (10 > 5)
        {
            // Verdadeiro
        }
        else
        {
            // False
        }

        var num = 1;
        if (num >= 18)
        {
            Console.WriteLine($"Idade: {num}, MAIOR de idade");
        }
        else
        {
            Console.WriteLine($"Idade: {num}, MENOR de idade.");
        }

        // Else if
        int valorCodigo = 4;
        if (valorCodigo == 2)
        {
            Console.WriteLine($"Valor do código: {valorCodigo}");
        }
        else if (valorCodigo == 3)
        {
            Console.WriteLine($"Valor do código: {valorCodigo}");
        }
        else if (valorCodigo == 4)
        {
            Console.WriteLine($"Valor do código: {valorCodigo}");
        }
        else
        {
            Console.WriteLine($"Valor do código: {valorCodigo}");
        }

        switch (valorCodigo)
        {
            case 2:
                Console.WriteLine($"Valor do código: {valorCodigo}");
                break;

            case 4:
                Console.WriteLine($"Valor do código: {valorCodigo}");
                break;
            default:
                Console.WriteLine($"Valor do código inválido");
                break;
        }

        // ----------------------

        // Arrays e Laços
        string[] nomes = ["João", "Maria", "José"];

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }

        int index = 0;
        while (index < nomes.Length)
        {
            Console.WriteLine(nomes[index]);
            index++;
        }
    

        // ----------------------
        // Coleções
        List<int> idades = new();
        List<string> nomesAlunos = new() { "João", "Maria", "José" };

        idades.Add(25);
        idades.Add(28);
        
        nomesAlunos.Add("Pri");
        
        nomesAlunos.Insert(0, "Patricia"); // Aqui coloca na primeira posição

        foreach (var idade in idades)
        {
           Console.WriteLine(idade); 
        }

        for (int i = 0; i < nomesAlunos.Count; i++)
        {
            Console.WriteLine(nomesAlunos[i]);
        }
        
        // ----------
        // Dicionário
        Dictionary<string, int> idadePessoas = new Dictionary<string, int>();
        
        idadePessoas.Add("Patricia", 30);
        idadePessoas.Add("Claudio", 31);
        idadePessoas.Add("Igor", 19);

        Console.WriteLine($"A pessoa tem {idadePessoas["Patricia"]} anos.");

        HashSet<int> hashSetNumeros = new HashSet<int>() { 0, 1, 2 };
        hashSetNumeros.Add(1);
        hashSetNumeros.Add(2);
        hashSetNumeros.Add(3);
        hashSetNumeros.Add(4);
        hashSetNumeros.Add(4);

        foreach (int i in hashSetNumeros)
        {
            Console.WriteLine(i);
        }

        // ----------------------
        // Conversão de Dados
        //Cast
        int valor = (int)2.5;
        
        //Parse
        int valorParse = int.Parse("0");
        
        //TryParse
        string numString = "45";
        int valorTryParse = int.TryParse(numString, out valor) ? valor : 0;
        
        Console.WriteLine(valorTryParse);
    }
}