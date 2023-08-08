/*

Desenvolva um programa que conte quantas vezes cada palavra aparece em um 
texto fornecido pelo usuário. 
Use um dicionário para armazenar as palavras e suas contagens. 
 
*/

using System;
using System.Collections.Generic;

namespace MeuProjeto
{
    class Dicionario
    {
        public string Palavra;
        public int Quantidade = 0;

        public Dicionario(string palavra, int quantidade)
        {
            Palavra = palavra;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"Palavra: {Palavra}, Quantidade: {Quantidade}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um texto");
            string texto = Console.ReadLine();

            string[] palavras = texto.Split(' ');

            List<Dicionario> dicionario = new List<Dicionario>();

            foreach (string palavra in palavras)
            {
                bool encontrada = false;

                foreach (Dicionario dic in dicionario)
                {
                    if (palavra == dic.Palavra)
                    {
                        dic.Quantidade++;
                        encontrada = true;
                        break;
                    }
                }

                if (!encontrada)
                {
                    dicionario.Add(new Dicionario(palavra, 1));
                }
            }

            foreach (Dicionario dic in dicionario)
            {
                Console.WriteLine(dic.ToString());
            }
        }
    }
}
