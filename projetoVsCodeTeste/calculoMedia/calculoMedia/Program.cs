Console.WriteLine("Digite a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

if (media >= 7)
{
    Console.WriteLine($"Sua nota é: {media}, você está aprovado!");
}
else if (media >= 5 && media < 7)
{
    Console.WriteLine($"Você está de recuperação, pois sua nota é: {media}, menor que 7");
}
else
{
    Console.WriteLine($"Você está reprovado, pois sua nota é: {media}, menor que 5");
}
