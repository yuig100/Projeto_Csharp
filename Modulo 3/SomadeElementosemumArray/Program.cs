/*

Crie um programa que solicite ao usuário que insira cinco números inteiros. 
Armazene esses números em um array e, em seguida, 
calcule e exiba a soma de todos os elementos do array. 
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {

            int tamanho = 5;

            int[] array = new int[tamanho];

            int numero;

            for (int i=0;i < tamanho; i++)
            {

                Console.WriteLine($"Digite o {i+1}º numero");
                numero = int.Parse( Console.ReadLine() );

                array[i] = numero;

            }

            foreach(int num in array)
            {
                Console.Write(num + " ");
            }

        }
    }
}
