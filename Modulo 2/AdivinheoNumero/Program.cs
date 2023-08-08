/*
 
Desenvolva um jogo em que o programa gera um número aleatório entre 1 e 100, 
e o usuário tenta adivinhar qual é esse número. 
O programa deve fornecer dicas (maior ou menor) até que o usuário adivinhe corretamente.
 
 */

using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {

            Random random = new Random();

            int numeroaleatorio = random.Next(1, 101);

            int escolha = 0;

            while (escolha != numeroaleatorio)
            {

                Console.WriteLine("Digite um numero");

                escolha = int.Parse(Console.ReadLine());

                if (escolha > numeroaleatorio)
                {
                    Console.WriteLine("O numero é Menor");
                }
                else if (escolha < numeroaleatorio)
                {
                    Console.WriteLine("O numero é Maior");
                }
                else
                {
                    Console.WriteLine("Você Acertou!");
                }
            }
        }
    }
}
