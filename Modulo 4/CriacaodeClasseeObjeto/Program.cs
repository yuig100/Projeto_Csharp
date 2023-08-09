/*
 
Crie uma classe chamada Pessoa com propriedades para armazenar nome, idade e altura. 
Em seguida, crie um objeto da classe Pessoa e atribua valores às propriedades. 
Imprima as informações do objeto.
 
*/

using System;

namespace MeuProjeto
{
    class Pessoa
    {

        public string Nome = "Sem nome";
        public int Idade = 0;
        public double Altura = 0.0;

        public Pessoa(string nome,int idade,double altura)
        {

            Nome = nome;
            Idade = idade;
            Altura = altura;

        }

        public void Apresentar()
        {

            Console.WriteLine($"{Nome} {Idade} {Altura}");

        }

    }
    
    class Program
    {
        static void Main()
        {

            string nome = "Pedro";
            int idade = 26;
            double altura = 1.66;

            Pessoa pessoa = new Pessoa(nome,idade,altura);

            pessoa.Apresentar();

        }
    }
}