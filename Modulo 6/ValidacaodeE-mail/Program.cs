/*
 
Crie um programa que solicite ao usuário digitar um endereço de e-mail e valide se o 
formato do e-mail é válido (por exemplo, contém um "@" e um domínio válido). 

*/

using System;
using System.Text;

namespace MeuProjeto
{
    class Program
    {

        public static bool VerificarEmail(string email)
        {
            bool arroba = false;

            bool domino = false;

            foreach (char item in email)
            {

                if (arroba == true)
                {

                    if (item == '.')
                    {

                        domino = true;

                    }

                }

                if (item == '@')
                {

                    arroba = true;

                }

            }

            if(arroba == true && domino == true)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        static void Main()
        {
            Console.WriteLine("Digite um email.");
            //string email = Console.ReadLine();

            string email = "pedro@hotmail.com";

            bool valid = VerificarEmail(email);

            Console.WriteLine(valid);

        }
    }
}
