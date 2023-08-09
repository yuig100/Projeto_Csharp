/*
 
Crie uma classe base chamada Animal com propriedades para nome e idade. 
Em seguida, crie duas classes derivadas, Cachorro e Gato, que herdam da classe base Animal. 
Adicione propriedades específicas para cada classe derivada, como raça para o Cachorro e cor 
para o Gato.
 
*/

using System;

namespace MeuProjeto
{
    class Animal
    {

        public string Nome;
        public int Idade;

        public Animal(string nome,int idade) 
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void toString()
        {

            Console.WriteLine($"{Nome} {Idade}");

        }

    }

    class Cachorro : Animal
    {

        public string Raça;

        public Cachorro(string nome, int idade, string raça) : base(nome,idade)
        {


            Raça = raça;

        }

        public override void toString()
        {

            Console.WriteLine($"{Nome} {Idade} {Raça}");

        }

    }

    class Gato : Animal
    {

        public string Cor;

        public Gato(string nome, int idade, string cor) : base(nome, idade)
        {

            Cor = cor;

        }

        public override void toString()
        {

            Console.WriteLine($"{Nome} {Idade} {Cor}");

        }

    }

    class Program
    {
        static void Main()
        {

            Animal animal = new Animal("animal", 1);
            Cachorro cachorro = new Cachorro("cachorro", 2, "labrador");
            Gato gato = new Gato("gato", 3, "vermelho");

            animal.toString();
            cachorro.toString();
            gato.toString();
        }
    }
}
