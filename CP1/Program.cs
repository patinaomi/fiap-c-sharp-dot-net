// Cálculo do Índice de Massa Corporal (IMC)

Console.Write("Digite a sua altura em metros: ");
double altura = double.Parse(Console.ReadLine());

Console.Write("Digite o seu peso em kg: ");
double peso = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);
Console.WriteLine($"Seu IMC é {imc:f2}", imc);
    
if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso.");
}
else if (imc < 24.9)
{
    Console.WriteLine("Peso normal.");
}
else if (imc < 29.9)
{
    Console.WriteLine("Sobrepeso");
}
else
{
    Console.WriteLine("Obesidade.");
}

// Classificação de Idade
Console.Write("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 12)
{
    Console.WriteLine("Criança.");
} else if (idade < 18) // Não coloquei o idade < 12 pois ficaria redundante
{
    Console.WriteLine("Adolescente.");
} else if (idade < 60)
{
    Console.WriteLine("Adulto.");
} 
else
{
    Console.WriteLine("Idoso.");
}