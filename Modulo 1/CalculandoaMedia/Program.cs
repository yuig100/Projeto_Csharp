/*

Crie um programa que calcule a média de três notas fornecidas pelo usuário. 
Exiba a média no final.

 */

using System;

namespace MeuProjeto
{
    class Program
    {
        
        static double Media(double n1,double n2,double n3)
        {

            return (n1+n2+n3) / 3;

        }
        
        static void Main()
        {
            Console.WriteLine("Digite a primeira nota");
            string input1 = Console.ReadLine();
            double nota1 = double.Parse(input1);

            Console.WriteLine("Digite a segunda nota");
            string input2 = Console.ReadLine();
            double nota2 = double.Parse(input2);

            Console.WriteLine("Digite a terceira nota");
            string input3 = Console.ReadLine();
            double nota3 = double.Parse(input3);

            Console.WriteLine($"A Média das notas é {Media(nota1, nota2, nota3)}");


        }
    }
}
