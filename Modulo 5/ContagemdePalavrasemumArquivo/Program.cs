/*
 
Crie um programa que leia um arquivo de texto e conte quantas vezes uma determinada palavra 
aparece no texto.
 
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace MeuProjeto
{

    class Dicionario
    {

        public string Palavra;
        public int Quantidade = 0;

        public Dicionario(string palavra,int quantidade)
        {

            Palavra = palavra;
            Quantidade = quantidade;

        }

        public override string ToString()
        {

            return $"Palavra:{Palavra} Quantidade:{Quantidade}";

        }

    }


    class Program
    {

        public static void ContarPalavras(string[] palavras)
        {

            List<Dicionario> dicionario = new List<Dicionario>();

            foreach (string pal in palavras)
            {

                bool existe = false;

                foreach (Dicionario s in dicionario)
                {

                    if(pal == s.Palavra)
                    {
                        s.Quantidade ++;
                        existe = true;
                        break;
                    }

                }

                if (!existe)
                {

                    dicionario.Add(new Dicionario(pal, 1));

                }

            }

            foreach (Dicionario dict in dicionario)
            {

                Console.WriteLine(dict.ToString());

            }
            
        }
        
        static void Main()
        {
            string texto = File.ReadAllText("arquivo.txt");

            string[] palavras = texto.Split(' ');

            ContarPalavras(palavras);

        }
    }
}
