Console.WriteLine("Digite sua posição: ");
int posicao = int.Parse(Console.ReadLine());

string mensagem = posicao == 1 ? "Parabéns, você é medalha de ouro!" :
                  posicao == 2 ? "Parabéns,você é medalha de prata!" :
                  posicao == 3 ? "Parabéns, você é medalha de bronze!" : "Você não está no ranking dos melhores, pois está abaixo do 3º lugar. ç-ç";

Console.WriteLine($"Sua posição é: {posicao}º. {mensagem}");