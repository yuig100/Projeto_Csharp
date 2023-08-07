/*

Crie um programa que converta uma temperatura de Celsius para Fahrenheit. 
O usuário deve inserir a temperatura em Celsius, e o programa deve calcular e exibir a temperatura 
equivalente em Fahrenheit usando a fórmula: Fahrenheit = (Celsius × 9/5) + 32.

*/

using System;

namespace ConversordeTemperatura
{
    class Program
    {
        static double CToF(double c)
        {

            return ((c * 9 / 5) + 32);

        }

        static void Main()
        {
            Console.WriteLine("Digite uma temperatura em Celsius");
            string resposta = Console.ReadLine();
            double celsius = double.Parse(resposta);

            double f = CToF(celsius);

            Console.WriteLine($"A temperatura em Fahrenheit é {f}");
        }
    }
}
