/*
 
Crie um programa que solicite ao usuário que insira dez números inteiros. 
Armazene esses números em um array e ordene o array em ordem crescente.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {

        static int[] Ordenar(int[] x)
        {
            int cont = 0;
            int meio = 0;

            foreach (int a in x)
            {
                cont++;
            }

            for (int i = 0;i<cont-1 ;i++)
            {

                for (int j = i + 1;j<cont ;j++)
                {

                    if (x[i] > x[j])
                    {

                        meio = x[i];
                        x[i] = x[j];
                        x[j] = meio;

                    }

                }

            }

            return x;

        }

        static void Main()
        {
            int numeros = 10;

            int[] array = new int[numeros];

            for (int i=0;i< numeros ;i++)
            {
                Console.WriteLine($"Digite o {i+1}º Numero");
                array[i] = int.Parse(Console.ReadLine());
            }

            array = Ordenar(array);

            foreach (int n in array)
            {

                Console.WriteLine(n);

            }

        }
    }
}