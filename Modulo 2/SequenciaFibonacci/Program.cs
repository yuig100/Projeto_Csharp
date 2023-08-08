/*

Crie um programa que gere e exiba os primeiros n números da sequência de Fibonacci, 
onde n é fornecido pelo usuário. 

 */

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {

            int numero = 9;

            int antfib = 0;
            int posfib = 1;
            int finalfib = 0;


            if (numero == 1)
            {
                Console.WriteLine(0);
            }
            if(numero >= 2)
            {
                Console.WriteLine(0);
                Console.WriteLine(1);
            }

            for (int i = 2; i < numero; i++)
            {

                finalfib = antfib + posfib;

                Console.WriteLine(finalfib);
                
                antfib = posfib;

                posfib = finalfib;

            }

        }
    }
}