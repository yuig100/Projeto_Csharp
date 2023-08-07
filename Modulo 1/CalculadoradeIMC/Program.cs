/*
 
Desenvolva um programa que calcule o índice de massa corporal (IMC) de uma pessoa. 
O usuário deve fornecer o peso em quilogramas e a altura em metros. 
O programa deve calcular o IMC usando a fórmula: IMC = peso / (altura * altura), 
e exibir a classificação correspondente ao IMC (por exemplo, magreza, normal, sobrepeso, obesidade).
 
 */

using System;

namespace MeuProjeto
{
    class Program
    {

        static double IMC(double peso,double altura)
        {

            return peso / (altura * altura);

        }

        static void Main()
        {
            Console.WriteLine("Digite o Peso(quilogramas)");
            string input1 = Console.ReadLine();
            double peso = double.Parse(input1);

            Console.WriteLine("Digite a altura(metros)");
            string input2 = Console.ReadLine();
            double altura = double.Parse(input2);

            double indice = IMC(peso,altura);

            if(indice < 18.5 )
            {

                Console.WriteLine("Abaixo do Peso (Magreza)");

            }
            else if(indice >= 18.5 && indice <= 24.9)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (indice >= 25 && indice <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (indice >= 30 && indice <= 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (indice >= 35 && indice <= 39.9)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else if (indice >= 40)
            {
                Console.WriteLine("Obesidade Grau III (Obesidade Mórbida)");
            }
        }
    }
}
