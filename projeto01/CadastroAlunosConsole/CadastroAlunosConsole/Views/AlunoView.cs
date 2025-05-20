using CadastroAlunosConsole.Controller;
using CadastroAlunosConsole.Models;

namespace CadastroAlunosConsole.Views
{
    internal class AlunoView
    {
        private AlunoController controller = new();

        public void MostrarMenu()
        {
            int opcao;
            do
            {
                Console.WriteLine("=== Cadastro do Aluno no Senac ===");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Listar Alunos");
                Console.WriteLine("3 - Atualizar Alunos");
                Console.WriteLine("4 - Excluir Alunos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarAluno();
                        break;
                    case 2:
                        ListarAluno();
                        break;
                    case 3:
                        AtualizarAluno();
                        break;
                    case 4:
                        ExcluirAluno();
                        break;

                }
                Console.WriteLine("\nPressione 'Enter' para continuar... ");
                Console.ReadLine();

            } while (opcao != 0);
        }

        private void CadastrarAluno()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Curso: ");
            string curso = Console.ReadLine();
            Console.WriteLine("Data de nascimento: (dd/mm/aaaa)");
            DateTime data = DateTime.Parse(Console.ReadLine());

            controller.CadastrarAluno(nome, cpf, curso, data);
            Console.WriteLine("Aluno cadastrado com sucesso!");
        }
        private void ListarAluno()
        {
            List<Aluno> alunos = controller.ListarAlunos();
            Console.WriteLine("\n Lista de alunos cadastrados ==== ");

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"ID: {aluno.Id} | Nome: {aluno.Nome} | CPF: {aluno.CPF} | Curso: {aluno.Curso} | Data de nascimento: {aluno.DataNascimento}");
            }
        }

        public void AtualizarAluno()
        {

            Console.WriteLine("Digite o ID do aluno a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Novo nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Novo CPF: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Novo Curso: ");
            string curso = Console.ReadLine();

            Console.WriteLine("Nova data de nascimento: (dd/mm/aaaa)");
            DateTime data = DateTime.Parse(Console.ReadLine());

            bool atualizado = controller.AtualizarAluno(id, nome, cpf, curso, data);
            Console.WriteLine(atualizado ? "Aluno atualizado com sucesso! " : "Aluno não encontrado ou erro!");


        }

    public void ExcluirAluno()
        {
            Console.WriteLine("Digite o ID do aluno a ser excluido: ");
            int id = int.Parse(Console.ReadLine());

            bool excluido = controller.ExcluirAluno(id);
            Console.WriteLine(excluido ? "Aluno exluido com sucesso!" : "Aluno não excluído! ç-ç");
        }
    }
}


// crtl r g = limpa código não utilizados.
// crtl k c comenta o que tiver selecionado
// crtl k u tira o comentário 
// crtl k d identa o código 