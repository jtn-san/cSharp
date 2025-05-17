using CadastroAlunosConsole.Controller;

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
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: CadastrarAluno();break;
                    //case 2: ListarAluno();
                    //    break;
                    //case 3: AtualizarAluno();
                    //    break;
                    //case 4: ExcluirAluno();
                    //    break;

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
        //private void ListarAluno()
        //{

        //}
        //private void AtualizarAluno()
        //{

        //}
        //private void ExcluirAluno()
        //{

        //}
    }
}


// crtl r g = limpa código não utilizados.
// crtl k c comenta o que tiver selecionado
// crtl k u tira o comentário 
// crtl k d identa o código 