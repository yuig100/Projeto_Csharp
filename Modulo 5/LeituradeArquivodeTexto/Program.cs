/*
 
Crie um programa que leia o conteúdo de um arquivo de texto e exiba seu conteúdo no console.
 
*/

using System;
using System.IO;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            string conteudo = "Olá, mundo!";

            File.WriteAllText("arquivo.txt",conteudo);

            string conteudoLido = File.ReadAllText("arquivo.txt");

            Console.WriteLine(conteudoLido);

        }
    }
}