/*

Desenvolva um programa que calcule o fatorial de um número fornecido pelo usuário. 
Use um loop for para realizar o cálculo. 
 
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
            int numero = int.Parse(input); //5

            int fat = 1;

            for (int i = numero;i > 1 ;i--)
            {

                fat = fat * i;

            }

            Console.WriteLine(fat);

        }
    }
}