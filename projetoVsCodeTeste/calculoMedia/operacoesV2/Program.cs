Console.WriteLine("Digite um número: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite mais um número: ");
double num2 = double.Parse(Console.ReadLine());

double resultadoDivisao = 0;


//try
//{
//    resultadoDivisao = num1 / num2;
//}
//catch (DivideByZeroException e)
//{

//    Console.WriteLine("Exception caught: {0}", e.Message);
//    resultadoDivisao = 0;
//}



//try
//{
//    resultadoDivisao = num1 / num2;
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine("Erro na divisão: {0}", e.Message);
//}
//finally
//{
//    // Exibe o resultado se a divisão foi realizada com sucesso
//    if (num2 != 0)
//    {
//        Console.WriteLine("Resultado: {0}", resultadoDivisao);
//    }
//    else
//    {
//        Console.WriteLine("Não foi possível realizar a divisão por zero.");
//        resultadoDivisao = 0;
//    }
//}


//try
//{

//    resultadoDivisao = num1 / num2;
//}
//catch (DivideByZeroException e)
//{

//    Console.WriteLine($"Exceção da divisão: {e.Message}");
//}

try
{
    resultadoDivisao = num1 / num2;

    if (Double.IsInfinity(resultadoDivisao) || Double.IsNaN(resultadoDivisao))
    {
        Console.WriteLine("\n A divisão resultou em um valor inválido.");
        resultadoDivisao = 0;

    }
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message); //"Erro: Tentativa de divisão por zero."
}

Console.WriteLine($"\nResultados das operações com os números digitados:" +
    $"\n-- Soma: {num1 + num2}" +
    $"\n-- Subtração: {num1 - num2}" +
    $"\n-- Multiplicação: {num1 * num2}" +
    $"\n-- Divisão: {resultadoDivisao}");



//int soma = num1 + num2;
//int subtracao = num1 + num2;
//int multiplicacao = num1 + num2;
//int divisao = num1 + num2;


//Console.ReadLine($"A soma desses números é: " + { soma});
//Console.ReadLine($"A subtração desses números é: " + { subtracao});
//Console.ReadLine($"\n--\n A subtração desses números é: " + { multiplicacao});
//Console.ReadLine($"\n--\n A subtração desses números é: " + { divisao});

// : F2 após interpolação de string, 