/*
 
Expanda um dos exercícios anteriores para permitir a leitura e escrita de objetos em um 
arquivo usando serialização.
 
*/

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MeuProjeto
{
    [Serializable]
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

            return $"Palavra:{Palavra} Quantidade:{Quantidade}";

        }

    }

    [Serializable]
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

                    if (pal == s.Palavra)
                    {
                        s.Quantidade++;
                        existe = true;
                        break;
                    }

                }

                if (!existe)
                {

                    dicionario.Add(new Dicionario(pal, 1));

                }

            }

            string json = JsonConvert.SerializeObject(dicionario, Formatting.Indented);
            File.WriteAllText("dicionario.json", json);

            string jsonLido = File.ReadAllText("dicionario.json");
            List<Dicionario> dicionarioLido = JsonConvert.DeserializeObject<List<Dicionario>>(jsonLido);

            foreach (Dicionario dict in dicionarioLido)
            {
                Console.WriteLine(dict.ToString());
            }

            /*
            foreach (Dicionario dict in dicionario)
            {

                Console.WriteLine(dict.ToString());

            }
            */
        }

        static void Main(string[] args)
        {
            string texto = File.ReadAllText("arquivo.txt");

            string[] palavras = texto.Split(' ');

            ContarPalavras(palavras);

        }
    }
}

