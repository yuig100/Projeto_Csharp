/*
 
Desenvolva um programa que solicite ao usuário digitar um número de CPF e formate-o 
no formato "xxx.xxx.xxx-xx".
 
*/

using System;
using System.Text;

namespace MeuProjeto
{
    class Program
    {

        public static string CPF(string cpf)
        {
            StringBuilder newcpf = new StringBuilder();

            int i = 0;

            cpf = cpf.ToString().Replace(" ","");
            cpf = cpf.ToString().Replace(".", "");
            cpf = cpf.ToString().Replace("-", "");
            cpf = cpf.ToString().Replace("/", "");

            foreach (char c in cpf)
            {

                if (i == 3 || i == 6)
                {

                    newcpf.Append(".");


                }

                if (i == 9)
                {
                    newcpf.Append("-");
                }

                newcpf.Append(c);

                i++;

            }

            return newcpf.ToString();
        }

        static void Main()
        {
            Console.WriteLine("Digite um numero de CPF");
            string cpf = Console.ReadLine();

            Console.WriteLine(CPF(cpf));

        }
    }
}
