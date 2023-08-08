/*

Desenvolva um programa que permita ao usuário inserir notas de alunos (por exemplo, 10 notas). 
Armazene essas notas em um array e calcule a média delas.
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {

        static int Media(int[] notas)
        {

            int i = 0;
            int somanotas = 0;

            foreach (int not in notas)
            {

                i++;

                somanotas = not + somanotas;

            }

            return somanotas / i;

        }

        static void Main()
        {
            int numero = 3;

            int[] notas = new int[numero];

            int variavel;

            for(int i = 0;i < numero; i++)
            {

                Console.WriteLine($"Digite a {i + 1}º Nota");
                variavel = int.Parse( Console.ReadLine() );

                notas[i] = variavel;

            }

            int media = Media(notas);

            Console.WriteLine(media);

        }
    }
}
