ExibirMensagem();
Somar(10, 5);
EhPar(10);
CalcularMedia(5,4);

void ExibirMensagem()
{
    Console.WriteLine("Função Mensagem");
}


int Somar(int a,  int b)
{
    Console.WriteLine(a+b);
    return a + b;
}

bool EhPar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(true);
        return true;
    } else
    {
        Console.WriteLine(false);
        return false;
    }
}

double CalcularMedia(double n1, double n2)
{
    Console.WriteLine(((n1+n2)/2).ToString("F"));
    return (n1 + n2) / 2;
}