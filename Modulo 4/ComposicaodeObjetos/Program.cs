/*
 
Expanda o exercício anterior adicionando uma classe Turma, 
que representa um conjunto de alunos matriculados em um determinado curso. 
Utilize a composição de objetos para criar uma relação entre as classes Turma, Aluno e Curso.
 
*/

using System;
using System.Collections.Generic;

namespace MeuProjeto
{
    class Aluno
    {
        public int Id;
        public string Nome;
        public List<Turma> Turmas = new List<Turma>();

        public Aluno(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void Matricular(Turma turma)
        {
            Turmas.Add(turma);
            turma.AdicionarAluno(this);
        }
    }

    class Curso
    {
        public int Id;
        public string Nome;
        public List<Turma> Turmas = new List<Turma>();

        public Curso(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarTurma(Turma turma)
        {
            Turmas.Add(turma);
        }
    }

    class Turma
    {
        public Curso Curso;
        public List<Aluno> Alunos = new List<Aluno>();

        public Turma(Curso curso)
        {
            Curso = curso;
        }

        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
    }

    class Program
    {
        static void Main()
        {
            Aluno aluno1 = new Aluno(1, "João");
            Aluno aluno2 = new Aluno(2, "Maria");

            Curso curso1 = new Curso(1, "Matemática");
            Curso curso2 = new Curso(2, "História");

            Turma turma1 = new Turma(curso1);
            Turma turma2 = new Turma(curso2);

            aluno1.Matricular(turma1);
            aluno1.Matricular(turma2);
            aluno2.Matricular(turma1);

            Console.WriteLine($"{aluno1.Nome} está matriculado nas turmas:");
            foreach (Turma turma in aluno1.Turmas)
            {
                Console.WriteLine($"- {turma.Curso.Nome}");
            }

            Console.WriteLine($"{aluno2.Nome} está matriculado nas turmas:");
            foreach (Turma turma in aluno2.Turmas)
            {
                Console.WriteLine($"- {turma.Curso.Nome}");
            }

            Console.WriteLine($"{curso1.Nome} tem as seguintes turmas:");
            foreach (Turma turma in curso1.Turmas)
            {
                Console.WriteLine($"- {turma.Curso.Nome}");
            }
        }
    }
}
