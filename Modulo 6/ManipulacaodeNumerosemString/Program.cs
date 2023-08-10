/*
 
Crie um programa que leia um número como uma string (por exemplo, "1234") 
e o converta em um valor inteiro.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um Numero");

            string exemplo = Console.ReadLine();

            int numero = int.Parse(exemplo);
        }
    }
}
