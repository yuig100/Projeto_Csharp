/*
 
Desenvolva um programa que verifica se uma palavra fornecida pelo usuário é um 
palíndromo (lê-se da mesma forma da esquerda para a direita e vice-versa), 
ignorando espaços e diferenciação entre letras maiúsculas e minúsculas. 
 
*/

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite uma palavra");

            string palavra = Console.ReadLine();

            palavra = palavra.Replace(" ","").ToLower();

            int esquerda = 0;
            int direita = palavra.Length - 1;

            bool palin = true;

            while(esquerda < direita)
            {
                if (palavra[esquerda] != palavra[direita]) {

                    palin = false;
                    break;
                
                }

                esquerda++;
                direita--;

            }

            if(palin == true)
            {
                Console.WriteLine("É um palíndromo");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo");
            }

        }
    }
}