/*
 
Crie um programa que solicite ao usuário digitar uma frase e conte quantos 
caracteres (incluindo espaços) a frase contém.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {

        static int ContarCaracteres(string frase)
        {

            int i = 0;

            foreach (char a in frase)
            {

                i++;

            }

            return i;

        }

        static void Main()
        {
            Console.WriteLine("Digite uma frase!");
            string frase = Console.ReadLine();

            int quantidade = ContarCaracteres(frase);

            Console.WriteLine(quantidade);
        }
    }
}