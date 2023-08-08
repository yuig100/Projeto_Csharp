/*
 
Desenvolva um programa que permita ao usuário inserir um número inteiro e verifique 
se esse número está presente em um array pré-definido.
 
 */

using System;

namespace MeuProjeto
{
    class Program
    {

        static bool Verificacao(int[] array,int x)
        {

            foreach (int i in array)
            {

                if(i == x)
                {

                    return true;

                }

            }

            return false;

        }

        static void Main()
        {
            int[] arraypre = { 1,2,3};


            Console.WriteLine("Digite um numero");
            int resposta = int.Parse(Console.ReadLine());

            bool verify = false;

            verify = Verificacao(arraypre, resposta);

            if (verify == false)
            {
                Console.WriteLine("O numero não está presente!");
            }else
            {
                Console.WriteLine("O numero está presente!");
            }

        }
    }
}
