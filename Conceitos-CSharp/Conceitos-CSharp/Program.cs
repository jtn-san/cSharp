// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Tipos númericos 
byte b = 10;
int idade = 25;
long populacao = 7000000000;


// Tipos Reais
float peso = 60.2f;
double altura = 1.78;
decimal salario = 2500.99m;


// Lógico e texto
bool aprovado = true;
char incial = 'P';
string nome = "P";

// Inferência com var

var cidade = "São Paulo";
var nota = 8.5;
var letra = 'A';
var boleana = true;

Console.WriteLine("Nome: " + nome);
Console.WriteLine($"Nome: {nome}"); // Interpola
Console.WriteLine($"Idade: {idade}");

double media, numero1, numero2;

Console.WriteLine("Digite a primeira nota: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
numero2 = Convert.ToDouble(Console.ReadLine());

media = (numero1 + numero2)/2;

Console.WriteLine($"A média do aluno é: {media}");

    if (media >= 5){
    Console.WriteLine("Parabéns, você foi aprovado!");
} else {
    Console.WriteLine("Infelizmente, você foi reprovado.");
}

    


//Console.WriteLine("Digite sua profissão: ");
//profissao = Console.ReadLine();
//Console.WriteLine("");