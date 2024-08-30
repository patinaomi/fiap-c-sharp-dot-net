namespace Primeiro_Projeto_OOP;

class Program
{
    static void Main(string[] args)
    {
        // Declarando variáveis
        byte idade = 25;
        sbyte temperatura = -10;
        
        short populacao = 1000;
        ushort identificador = 10;
        
        int quantidade = 10;
        uint quantidade2 = 10;
        
        long distancia = 100000;
        ulong distancia2 = 100000;

        float altura = 1.75f;
        double peso = 60.5;
        decimal preco = 18.55m;

        char letra = 'P';

        bool estaChovendo = true;
        
        // Operadores Aritméticos
        int numero1 = 10;
        int numero2 = 5;
        
        int soma = numero1 + numero2;
        Console.WriteLine($"Soma: {soma}");
        int subtracao = numero1 - numero2;
        Console.WriteLine(subtracao);
        int multiplicacao = numero1 * numero2;
        Console.WriteLine(multiplicacao);
        int divisao = numero1 / numero2;
        Console.WriteLine(divisao);
        
        // Operadores de Incremento e Decremento
        int contador = 5;
        
        // Pós Incremento
        Console.WriteLine($"Contador: {contador++}"); // 10
        Console.WriteLine($"Contador: {contador++}"); // 15

        // Pré Incremento
        int contadorPre = 5;
        Console.WriteLine($"Valor da operação: {++contadorPre}"); // 6

        // Constantes
        const int codigo = 2;
        
        //String
        char valor = 'A';

        string nome = "Patricia";
        string sobrenome = "Naomi";
        
        //Concatenação
        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine(nomeCompleto);
        
        // Interpolação de Strings
        Console.WriteLine($@"Nome Completo: {nome} {sobrenome} // Esse @ Ajuda a quebrar a linha
Idade: {idade}");

        // Manipulações
        Console.WriteLine($"Número de caracteres é: {sobrenome.Length}");
        Console.WriteLine($"Primeira letra do nome: {sobrenome[0]}");
        Console.WriteLine($"Última letra do nome: {sobrenome[sobrenome.Length - 1]}");
        Console.WriteLine($"Nome em maiúsculo: {sobrenome.ToUpper()}");
        Console.WriteLine($"Nome em minúsculo: {sobrenome.ToLower()}");
        sobrenome = sobrenome.Replace("Naomi", "yamagishi");
        Console.WriteLine($"Nome com a primeira letra maiúscula: {char.ToUpper(sobrenome[0])}{sobrenome.Substring(1)}");
        
        // Exercício
        Console.Write("Digite o seu nome: ");
        string? nomeUsuario = Console.ReadLine(); // Esse ? quer dizer que pode aceitar nulo
        
        Console.Write("Digite o seu sobrenome: ");
        string? sobrenomeUsuario = Console.ReadLine();
        
        Console.WriteLine($"Nome Completo: {nomeUsuario} {sobrenomeUsuario}");

        int age = 18;
        // Operadores de Condição
        if (age >= 18)
        {
            Console.WriteLine("Maior de Idade");
        }
        else
        {
            Console.WriteLine("Menor de Idade");
        }

        int code = 18;
        if (code == 2)
        {
            Console.WriteLine($"Código é {code}");
        }
        else if(code == 3)
        {
            Console.WriteLine($"Código é {code}");
        }
        else
        {
            Console.WriteLine("Código não encontrado");
        }

        switch (code)
        {
            case 2:
                Console.WriteLine($"Código é {code}");
                break;
            case 4:
                Console.WriteLine($"Código é {code}");
                break;
            default:
                Console.WriteLine("Código não encontrado");
                break;
        }
        
        // Array e Laços de Repetição
        string[] nomes = { "Pati", "Sarita", "Mari" };

        foreach (string i in nomes)
        {
            Console.WriteLine(i);
        }
        
        for(int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }
        
        Console.WriteLine();
        int index = 0;
        
        while(index < nomes.Length)
        {
            Console.WriteLine(nomes[index]);
            index++;
        }
    }
}