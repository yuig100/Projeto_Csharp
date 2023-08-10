/*
 
Desenvolva um programa que receba uma string do usuário e retorne a mesma string, mas invertida.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {
        
        public static string Inverter(string palavra)
        {

            char[] chars = palavra.ToCharArray();

            Array.Reverse(chars);

            return new string(chars);
        }
        
        static void Main()
        {
            Console.WriteLine("Digite uma palavra");
            string palavra = Console.ReadLine();

            string palavra2 = Inverter(palavra);

            Console.WriteLine(palavra2);

        }
    }
}
