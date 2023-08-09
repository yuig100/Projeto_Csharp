/*
 
Desenvolva um programa que leia um arquivo binário e exiba seu conteúdo em formato legível.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            byte[] conteudo = File.ReadAllBytes("arquivo.bin");

            string base1 = Convert.ToBase64String(conteudo);

           
            // Converter para Base64
            foreach (char b in base1)
            {
                Console.Write(b);
            }

            
        }
    }
}
