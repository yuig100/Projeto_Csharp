/*
 
Crie um programa que gere uma matriz de multiplicação de tamanho n x n, 
onde n é um número fornecido pelo usuário. 
Preencha a matriz com os resultados da multiplicação de linha por coluna.
 
 */

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um numero");

            int numero = int.Parse(Console.ReadLine());

            int[][] matriz = new int[numero][];

            for (int i=1;i<=numero ;i++)
            {
                matriz[i-1] = new int[numero];
                for (int j=1;j<=numero ;j++)
                {
                    matriz[i-1][j-1] = i * j;
                }
            }

            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
