Console.WriteLine("Digite sua posição: ");
int posicao = int.Parse(Console.ReadLine());

switch (posicao) {

    case 1:
        Console.WriteLine($"Sua posição é: {posicao},º você é medalha de ouro!");
        break;
    case 2:
    Console.WriteLine($"Sua posição é: {posicao},º você é medalha de prata!");
        break;
    case 3:
    Console.WriteLine($"Sua posição é: {posicao},º você é medalha de bronze!");
        break;
    default:
    Console.WriteLine($"Você não está no ranking dos melhores, pois sua posição é: {posicao},º abaixo do 3º lugar. ç-ç ");
        break;
}