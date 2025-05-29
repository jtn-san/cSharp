public class Forma
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Desenhando uma forma genérica");
    }
}

public class Circulo : Forma
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um círculo");
    }
}
