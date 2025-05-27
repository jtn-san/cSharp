Console.WriteLine("Digite a potuação do Robô 1: ");
double robo1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a potuação do Robô 2: ");
double robo2 = double.Parse(Console.ReadLine());

string mensagem = robo1 > robo2 ? "Robô 1 tem maior pontuação " : robo2 > robo1 ? "Robô 2 tem maior pontuação" : "Empate";

Console.WriteLine(mensagem);