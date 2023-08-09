/*
 
No contexto das classes Cachorro e Gato do exercício anterior, 
crie um método chamado EmitirSom() na classe base Animal e sobrescreva esse método nas 
classes derivadas. Implemente diferentes sons para cada tipo de animal.
 
*/

using System;

namespace MeuProjeto
{
    class Animal
    {

        public string Nome;
        public int Idade;

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void toString()
        {

            Console.WriteLine($"{Nome} {Idade}");

        }

        public virtual void EmitirSom()
        {

            Console.WriteLine("Grunido Generico!");

        }

    }

    class Cachorro : Animal
    {

        public string Raça;

        public Cachorro(string nome, int idade, string raça) : base(nome, idade)
        {


            Raça = raça;

        }

        public override void toString()
        {

            Console.WriteLine($"{Nome} {Idade} {Raça}");

        }

        public override void EmitirSom()
        {

            Console.WriteLine("Latido!");

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

        public override void EmitirSom()
        {

            Console.WriteLine("Miado!");

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
            animal.EmitirSom();
            cachorro.toString();
            cachorro.EmitirSom();
            gato.toString();
            gato.EmitirSom();
        }
    }
}