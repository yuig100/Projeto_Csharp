/*

Desenvolva um programa que permita ao usuário digitar linhas de texto e salve essas linhas 
em um arquivo de texto.
 
*/

using System;
using System.IO;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um texto.");

            string texto = Console.ReadLine();

            File.WriteAllText("arquivo.txt",texto);

        }
    }
}
