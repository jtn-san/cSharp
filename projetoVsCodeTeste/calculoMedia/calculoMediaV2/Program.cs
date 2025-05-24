/*Console.WriteLine("Digite a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2) / 2;

string mensagem = media >= 7 ? "Aprovado" : "Reprovado";

Console.WriteLine($"Sua média é: {media}, você foi {mensagem}");



 .ToString("F") -- Converter o valor em duas. 
 */

Console.WriteLine("Digite a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2) / 2;

string mensagem = media >= 7 ? "Aprovado" :
                  media >= 5 ? "Recuperação" : "Reprovado";

Console.WriteLine($"Sua média é: {media}, você foi {mensagem}");