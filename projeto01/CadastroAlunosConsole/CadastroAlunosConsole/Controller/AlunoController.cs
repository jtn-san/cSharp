using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroAlunosConsole.Models;

namespace CadastroAlunosConsole.Controller
{
    public class AlunoController
    {
        private List<Aluno> alunos = new();
        private int proximoId = 1;

        public void CadastrarAluno(string nome, string cpf, string curso, DateTime dataNascimento)
        {
            Aluno novoAluno = new(proximoId++, nome, cpf, curso, dataNascimento);
            alunos.Add(novoAluno);
        }
    }
}


// crtl r g = limpa código não utilizados.
// crtl k c comenta o que tiver selecionado
// crtl k u tira o comentário 
// crtl k d identa o código 