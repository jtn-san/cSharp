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
            //breakpoint = a aplicação para analisarmos os dados que já se encontra na função. 
            alunos.Add(novoAluno);
        }

        public List<Aluno> ListarAlunos()
        {
            return alunos; 
        }


        //bool = boleano
        public bool AtualizarAluno(int id, string nome, string cpf, string curso, DateTime dataNascimento)
        {
            Aluno aluno = alunos.Find(a => a.Id == id);
            if (aluno == null) return false;

            aluno.Nome = nome;
            aluno.CPF = cpf;
            aluno.Curso = curso;
            aluno.DataNascimento = dataNascimento; 
            return true;
        }


    }
}


// crtl r g = limpa código não utilizados.
// crtl k c comenta o que tiver selecionado
// crtl k u tira o comentário 
// crtl k d identa o código 