/*

Crie um programa que permita ao usuário digitar um número e determine se ele é par ou ímpar. 
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um Numero.");
            string input = Console.ReadLine();
            int numero = int.Parse(input);

            if(numero % 2 == 0)
            {

                Console.WriteLine("O Numero é Par!");

            }
            else
            {

                Console.WriteLine("O Numero é Impar!");

            }

        }
    }
}
