using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_explorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa novoAluno)
        {
            Alunos.Add(novoAluno);
        }

        public int ObterQuanditadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for(int i = 0; i < Alunos.Count; i++)
            {
                Console.WriteLine($"{i+1} - {Alunos[i].NomeCompleto}");
            }

        }
    }
}