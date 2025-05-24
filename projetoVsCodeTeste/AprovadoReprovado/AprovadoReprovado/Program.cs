Console.WriteLine("Digite a nota: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7) {
    Console.WriteLine($"Sua nota é: {nota}, você está aprovado!");
} else if (nota >= 5 && nota <= 6) {
    Console.WriteLine($"Você está de recuperação, pois sua nota é: {nota}, menor que 7");
} else
{
    Console.WriteLine($"Você está reprovado, pois sua nota é: {nota}, menor que 5");
}
