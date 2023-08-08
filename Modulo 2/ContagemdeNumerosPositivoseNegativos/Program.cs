/*
 
Crie um programa que solicite ao usuário que digite uma sequência de números. 
O programa deve contar e exibir quantos números são positivos e quantos são negativos. 
A entrada pode ser encerrada quando o usuário digitar 0.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {

            int entrada=1;

            int positivo = 0;
            int negativo = 0;

            while(entrada != 0)
            {

                Console.WriteLine("Digite um numero");
                entrada = int.Parse(Console.ReadLine());

                if(entrada > 0)
                {
                    positivo++;

                }else if(entrada < 0)
                {
                    negativo++;
                }

            }

            Console.WriteLine($"{positivo} numeros positivos!");
            Console.WriteLine($"{negativo} numeros negativos!");

        }
    }
}