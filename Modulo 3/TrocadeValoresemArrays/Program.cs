/*
 
Desenvolva um programa que troque os valores entre dois arrays do mesmo tamanho. 
Por exemplo, se array1 = [1, 2, 3] e array2 = [4, 5, 6], 
após a troca os arrays devem ser array1 = [4, 5, 6] e array2 = [1, 2, 3].
 
*/

using System;

namespace MeuProjeto
{

    class Program
    {
        static void Main()
        {
            int[] array1= { 1,2,3};
            int[] array2 = { 4,5,6};

            int cont = 0;
            int x;

            foreach (int a in array1)
            {
                cont++;
            }

            for (int i = 0; i < cont; i++)
            {
                x = array1[i];
                array1[i] = array2[i];
                array2[i] = x;
            }

            foreach(int z in array1){
                Console.WriteLine(z);
            }
            foreach (int z in array2)
            {
                Console.WriteLine(z);
            }
        }
    }
}