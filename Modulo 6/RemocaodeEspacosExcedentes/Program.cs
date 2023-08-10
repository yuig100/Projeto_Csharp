/*
 
Desenvolva um programa que leia um texto e remova espaços extras entre palavras, 
deixando apenas um espaço entre cada palavra.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Olá, mundo!");

            string texto = Console.ReadLine();

            texto = texto.Replace("  "," ");

            Console.WriteLine(texto);

        }
    }
}
