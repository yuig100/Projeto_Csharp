/*

Desenvolva um programa que permita ao usuário digitar um número base e um expoente. 
O programa deve calcular e exibir o resultado da potência. 

*/

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o numero base");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente");
            int expoente = int.Parse(Console.ReadLine());

            int numFinal = 1;

            for(int i=0; i < expoente ; i++)
            {
                numFinal = numero * numFinal;
            }

            Console.WriteLine(numFinal);

        }
    }
}