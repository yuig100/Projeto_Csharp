/*

Crie um programa que solicite ao usuário um número e 
mostre a tabela de multiplicação desse número de 1 a 10. 

 */

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um Numero");
            int numero = int.Parse(Console.ReadLine());

            for(int i = 1;i <= 10 ;i++)
            {

                Console.WriteLine($"{numero} x {i} = {i*numero}");

            }
        }
    }
}