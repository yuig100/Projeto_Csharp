/*

Desenvolva um programa que calcule a área de um retângulo. 
O usuário deve fornecer a largura e a altura do retângulo, e o programa deve calcular e 
mostrar a área (Área = largura × altura).
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {

        static double Area(double altura,double largura)
        {

            return altura * largura;

        }

        static void Main()
        {

            Console.WriteLine("Digite a Altura do triangulo!");
            string input1 = Console.ReadLine();
            double altura = double.Parse(input1);

            Console.WriteLine("Digite a Largura do triangulo!");
            string input2 = Console.ReadLine();
            double largura = double.Parse(input2);

            Console.WriteLine($"A Area do triangulo é {Area(altura, largura)}");

        }
    }
}
