/*
 
Desenvolva um programa que solicite ao usuário digitar um número. 
Utilize um bloco try-catch para lidar com a possibilidade de o usuário inserir um valor 
não numérico.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Digite um Numero");
                int numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine (ex.ToString());
            }
        }
    }
}
