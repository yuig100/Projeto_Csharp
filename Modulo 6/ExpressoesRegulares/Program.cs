/*
 
Desenvolva um programa que valide senhas seguindo critérios específicos, 
como conter pelo menos uma letra maiúscula, um número e ter um comprimento mínimo.
 
 */

using System;

namespace MeuProjeto
{
    class Program
    {
        
        public static bool Validacao(string senha)
        {
            bool maiuscula = false;
            bool numero = false;
            bool comprimento = false;

            int i = 0;

            foreach (char x in senha)
            {

                i++;



                if(char.IsDigit(x))
                {

                    numero = true;

                }

                if (char.IsUpper(x))
                {

                    maiuscula = true;

                }
            }

            if (i >= 8)
            {

                comprimento = true;

            }

            if(comprimento == true && maiuscula == true && numero == true)
            {

                return true;

            } else
            {

                return false;
            }

        }
        
        static void Main()
        {
            Console.WriteLine("Digite uma senha: ");

            string senha = Console.ReadLine();

            Console.WriteLine(Validacao(senha));

        }
    }
}
