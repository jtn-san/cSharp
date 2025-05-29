// Programação Orientada a Objetos
// Classes, atributos e métodos.

Pessoa pessoa = new Pessoa();


// Recebendo os valores para os atributos do objeto pessoa
//pessoa.nome = Console.ReadLine();
//pessoa.idade = int.Parse(Console.ReadLine());

// Atribuindo valores para os atributos do objetos diretamente
Console.WriteLine("\n");
pessoa.nome = "nome";
pessoa.idade = 2025;


// Acessando o método da classe pessoa.
pessoa.Apresentar();



// ---- Encapsulamento ---- //
Console.WriteLine("\n");
ContaBancaria conta = new ContaBancaria();
conta.Depositar(1000);
conta.Depositar(550.75);
conta.Sacar(10.75);

Console.WriteLine($"R${conta.ConsultarSaldo()}");

// ---- Herança ----// 
Console.WriteLine("\n");
Cachorro dog = new Cachorro();
//dog.nome = "Rexc";
//dog.raca = "Pug";
dog.Comer();
dog.Latir();

dog.DadosCachorro();


// ---- Polimorfismo ----// 
Console.WriteLine("\n");
Forma forma = new Circulo();
forma.Desenhar();


// ---- Abstração ----//
Console.WriteLine("\n");
Funcionario funcionario = new Gerente();
funcionario.CalcularSalario();