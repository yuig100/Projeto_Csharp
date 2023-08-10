/*
 
Crie um programa que leia um texto e permita ao usuário substituir todas as ocorrências 
de uma palavra por outra palavra.
 
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o texto:");
        string texto = Console.ReadLine();

        Console.WriteLine("Digite a palavra que deseja substituir:");
        string palavraAntiga = Console.ReadLine();

        Console.WriteLine("Digite a nova palavra:");
        string palavraNova = Console.ReadLine();

        string novoTexto = texto.Replace(palavraAntiga, palavraNova);

        Console.WriteLine("Texto com as substituições:");
        Console.WriteLine(novoTexto);
    }
}
