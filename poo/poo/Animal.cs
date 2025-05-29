using System.Threading.Channels;

public class Animal
{

    private string nome = "Sonic";
    private string raca = "Shitzu";

    public void Comer()
    {
        Console.WriteLine("O animal está comendo...");
    }
    public void DadosCachorro()
    {
        Console.WriteLine($"Nome: {this.nome} \n Raça: {this.raca}");
    }


}

// CLasse cachorro herda todos atributos do 'Animal'.

public class Cachorro : Animal
{

    public void Latir()
    {
        Console.WriteLine("O cachorro está latindo...");

    }

}


