Console.WriteLine("Digite sua posição: ");
int posicao = int.Parse(Console.ReadLine());

if (posicao == 1)
{
    Console.WriteLine($"Sua posição é: {posicao},º você é medalha de ouro!");
}
else if (posicao == 2)
{
    Console.WriteLine($"Sua posição é: {posicao},º você é medalha de prata!");
}
else if (posicao == 3)
{
    Console.WriteLine($"Sua posição é: {posicao},º você é medalha de bronze!");
}
else
{
    Console.WriteLine($"Você não está no ranking dos melhores, pois sua posição é: {posicao},º abaixo do 3º lugar. ç-ç ");
}