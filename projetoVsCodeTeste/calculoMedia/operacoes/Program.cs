Console.WriteLine("Digite um número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite mais um número: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Gostaria de somar (1),\n subtrair (2),\n multiplicar (3) ou\n dividir (4)? \n Digite a opção: ");
int opcao = int.Parse(Console.ReadLine());


switch (opcao)
{

    case 1:
        Console.WriteLine($"A soma dos números ditigitado é: {num1+num2}");
        break;
    case 2:
        Console.WriteLine($"A subtração dos números ditigitado é: {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"A multiplicação dos números ditigitado é: {num1 * num2}");
        break;
    case 4:
        Console.WriteLine($"A divisão dos números ditigitado é: {num1 / num2}");
        break;
    default:
        Console.WriteLine($"Está operação {opcao}, não existe, tente novamente. ç-ç ");
        break;
}
/*
 Clicar duas vezes sobre uma palavra CRLT RR > seleciona todas as palavras iguais > digite a nova palavra para renomear todas de uma vez. 
 */