Console.WriteLine("Digite o valor da carta: ");
double carta1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da segunda carta: ");
double carta2 = double.Parse(Console.ReadLine());

string mensagem = carta1 > carta2 ? "Carta 1 tem maior pontuação " : carta2 > carta1 ? "Carta 2 tem maior pontuação" : "Empate";

Console.WriteLine(mensagem);