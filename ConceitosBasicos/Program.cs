// Variáveis

byte idade = 25;
sbyte temperatura = -30; //valores inteiros de -128 a 127

short populacao = -1000;
ushort identificador = 1000;

int quantidade = 10;
uint estoque = 100; // Não aceita negativos

long distancia = 100000000;
ulong distancia2 = 10000000000;

float altura = 1.80f;
double peso = 80.5;
decimal preco  = 10.5m;

char letra = 'A';
string nome2 = "João";
bool aprovado = true;

//-----------------------------------------------------------------------------------------------

// Operadores
int numero1 = 10;
int numero2 = 2;

int soma = numero1 + numero2;
Console.WriteLine("Valor da operação: " + soma);

int subtracao = numero1 - numero2;
Console.WriteLine($"Valor da operação: {subtracao}"); // Interpolação de string

int multiplicacao = numero1 * numero2;
Console.WriteLine("Valor da operação: " + multiplicacao);

int divisao = numero1 / numero2;
Console.WriteLine($"Valor da operação: {divisao}");

int modulo = numero1 % numero2;
Console.WriteLine($"Resto da divisão: {modulo}");

// -----------------------------------------------------------------------------------------------

// Operadores de incremento e decremento
int contador = 0;

// Pós incremento (x++): Usa o valor atual e depois o incrementa.
contador++;
Console.WriteLine(contador);

int contador2 = 5;
// Pré incremento (++x): Incrementa o valor e depois o usa na expressão.
Console.WriteLine(++contador2);

// Decremento
int contador3 = 5;
contador3--;
Console.WriteLine(contador3);

// -----------------------------------------------------------------------------------------------

// Constantes
const int codigo = 1234;
Console.WriteLine(codigo);
// codigo = 1; - Não é possível alterar o valor de uma constante

// -----------------------------------------------------------------------------------------------
string nome = "Pati";
string sobrenome = "Naomi";

// Interpolação de string
Console.WriteLine($@"{nome}
     {sobrenome}");

// Manipuladores
Console.WriteLine(nome.ToUpper());
Console.WriteLine(nome.ToLower());
Console.WriteLine(nome.Length);

// -----------------------------------------------------------------------------------------------

// Exercicio - Capturando nome e sobrenome e imprimindo na tela
Console.WriteLine("Digite o seu nome: ");
string? nomeAluno = Console.ReadLine(); // ? - Permite que a variável seja nula

Console.WriteLine("Digite o seu sobrenome: ");
string? sobrenomeAluno = Console.ReadLine();

Console.WriteLine($"Nome completo: {nomeAluno} {sobrenomeAluno}");



     