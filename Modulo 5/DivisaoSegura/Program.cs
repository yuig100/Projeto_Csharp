/*
 
Crie um programa que peça ao usuário para digitar dois números. 
Utilize um bloco try-catch para lidar com a divisão desses números, 
considerando a possibilidade de divisão por zero.
 
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

                Console.WriteLine($"Digite o 1º Numero");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o 2º Numero");
                int num2 = int.Parse(Console.ReadLine());

                int ponto = num1 / num2;

                Console.WriteLine(ponto);

            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);

            }
        }
    }
}
