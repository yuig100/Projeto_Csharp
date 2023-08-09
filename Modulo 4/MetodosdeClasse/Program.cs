/*
 
Expanda a classe Pessoa do exercício anterior, adicionando um método para calcular 
o ano de nascimento com base na idade atual. 
Use este método para calcular e exibir o ano de nascimento do objeto Pessoa. 

*/

using System;

namespace MeuProjeto
{
    class Pessoa
    {

        public string Nome = "Sem nome";
        public int Idade = 0;
        public double Altura = 0.0;

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public void Apresentar()
        {
            Console.WriteLine($"{Nome} {Idade} {Altura}");
        }

        public void CalcularAno()
        {

            DateTime dataAtual = DateTime.Now;

            int ano = dataAtual.Year;

            Console.WriteLine(ano - Idade);

        }

    }

    class Program
    {
        static void Main()
        {

            string nome = "Pedro";
            int idade = 26;
            double altura = 1.66;

            Pessoa pessoa = new Pessoa(nome, idade, altura);

            pessoa.Apresentar();
            pessoa.CalcularAno();

        }
    }
}