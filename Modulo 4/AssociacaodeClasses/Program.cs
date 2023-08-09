/*
 
Crie classes Aluno e Curso. Um aluno pode estar matriculado em vários cursos, 
e um curso pode ter vários alunos. Implemente uma associação entre essas classes, 
permitindo que um aluno seja matriculado em vários cursos e vice-versa.
 
*/

using System;
using System.Collections.Generic;

namespace MeuProjeto
{
    class Aluno
    {
        public int Id;
        public string Nome;
        public List<Curso> cursos = new List<Curso>();

        public Aluno(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void Matricular(Curso curso)
        {
            cursos.Add(curso);
            curso.AdicionarAluno(this);
        }
    }

    class Curso
    {
        public int Id;
        public string Nome;
        public List<Aluno> alunos = new List<Aluno>();

        public Curso(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
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

            aluno1.Matricular(curso1);
            aluno1.Matricular(curso2);
            aluno2.Matricular(curso1);

            Console.WriteLine($"{aluno1.Nome} está matriculado nos cursos:");
            foreach (Curso curso in aluno1.cursos)
            {
                Console.WriteLine($"- {curso.Nome}");
            }

            Console.WriteLine($"{aluno2.Nome} está matriculado nos cursos:");
            foreach (Curso curso in aluno2.cursos)
            {
                Console.WriteLine($"- {curso.Nome}");
            }

            Console.WriteLine($"{curso1.Nome} tem os seguintes alunos:");
            foreach (Aluno aluno in curso1.alunos)
            {
                Console.WriteLine($"- {aluno.Nome}");
            }
        }
    }
}
