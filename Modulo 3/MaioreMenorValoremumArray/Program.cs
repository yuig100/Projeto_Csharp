/*

Crie um programa que solicite ao usuário que insira dez números inteiros. 
Armazene esses números em um array e encontre o maior e o menor valor dentro do array.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {

        static int[] MaioreMenor(int[] x)
        {

            int maior = x[0], menor = x[0];

            foreach(int y in x)
            {

                if(y > maior)
                {

                    maior = y;

                }

                if(y < menor)
                {

                    menor = y;

                }

            }

            int[] vetor = { menor, maior };

            return vetor;

        }


        static void Main()
        {
            int numeros = 10;

            int[] array = new int[numeros];

            int variavel = 0;

            for (int i = 0; i < numeros; i++)
            {

                Console.WriteLine($"Digite o {i + 1}º Numero");

                array[i] = int.Parse(Console.ReadLine());

            }

            array = MaioreMenor(array);

            Console.WriteLine($"O menor numero é {array[0]}");
            Console.WriteLine($"O maior numero é {array[1]}");

        }

    }
}