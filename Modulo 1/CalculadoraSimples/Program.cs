/*
Crie um programa que permita ao usuário digitar dois números e 
escolher uma operação (adição, subtração, multiplicação ou divisão) para calcular o resultado. 
Mostre o resultado ao final.
*/


using System;

namespace Calculadora
{
    class Program
    {

        static double adicao(double a,double b)
        {

            return a + b;

        }

        static double subtracao(double a,double b)
        {

            return a - b;

        }

        static double multiplicacao(double a,double b)
        {

            return a * b;

        }
        static double divisao(double a,double b){

            if(b == 0)
            {
                return 0;
            }else
            {
                return a / b;
            }

        }

        static void Menu()
        {

            Console.WriteLine("Digite o primeiro numero!");
            string input1 = Console.ReadLine();
            double a = double.Parse(input1);

            Console.WriteLine("Digite o segundo numero!");
            string input2 = Console.ReadLine();
            double b = double.Parse(input2);


            Console.WriteLine("Escolha uma das opções");
            Console.WriteLine("Digite 1 para adição");
            Console.WriteLine("Digite 2 para Subtração");
            Console.WriteLine("Digite 3 para Multiplicação");
            Console.WriteLine("Digite 4 para Divisão");

            string opcao = Console.ReadLine();

            double resposta = 0;

            if(opcao == "1")
            {
                resposta = adicao(a, b);

            } else if(opcao == "2")
            {

                resposta = subtracao(a, b);

            }
            else if(opcao == "3")
            {

                resposta = multiplicacao(a, b);

            }
            else if (opcao == "4")
            {

                resposta = divisao(a, b);

            }
            else{

                Console.WriteLine("Erro!");
                return;
            }

            Console.WriteLine(resposta);

        }

        static void Main()
        {

            Menu();

        }
    }
}
