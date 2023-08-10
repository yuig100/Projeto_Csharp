/*
 
Crie um programa que solicite ao usuário digitar uma data no formato "dd/mm/aaaa" 
e a exiba no formato "mês dd, aaaa" (por exemplo, "agosto 03, 2023").
 
*/

using System;
using System.Text;

namespace MeuProjeto
{
    class Program
    {
        public static string Formatar(string data)
        {

            string[] newdata = data.Split("/");

            if (newdata[1] == "01")
            {

                return $"janeiro {newdata[0]}, {newdata[2]}";

            } else if (newdata[1] == "02")
            {

                return $"fevereiro {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "03")
            {

                return $"março {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "04")
            {

                return $"abril {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "05")
            {

                return $"maio {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "06")
            {

                return $"junho {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "07")
            {

                return $"julho {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "08")
            {

                return $"agosto {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "09")
            {

                return $"setembro {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "10")
            {

                return $"outubro {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "11")
            {

                return $"novembro {newdata[0]}, {newdata[2]}";

            }
            else if (newdata[1] == "12")
            {

                return $"dezembro {newdata[0]}, {newdata[2]}";

            }
            else
            {

                return "formato errado";

            }

        }
        
        static void Main()
        {
            Console.WriteLine("Digite uma data(dd/mm/aaaa)");
            string data = Console.ReadLine();

            Console.WriteLine(Formatar(data));

        }
    }
}
