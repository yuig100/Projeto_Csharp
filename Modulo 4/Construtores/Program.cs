/*
 
Na classe ContaBancaria do exercício anterior, crie um construtor que aceite o número da conta 
como parâmetro. Implemente outro construtor que defina um saldo inicial e utilize 
o número da conta como "0000" por padrão.
 
*/

using System;

namespace MeuProjeto
{

    class ContaBancaria
    {

        public int Numeroconta;
        public double Saldo;

        public ContaBancaria(int numeroconta)
        {

            Numeroconta = numeroconta;

        }

        public ContaBancaria(double saldo)
        {

            Saldo = saldo;
            Numeroconta = 0000;

        }

        public ContaBancaria(int numeroconta, double saldo)
        {

            Saldo = saldo;
            Numeroconta = numeroconta;

        }

        public void SacarDinheiro(double valor)
        {
            if (valor > Saldo)
            {

                Console.WriteLine("Limite Excedido!");

            }
            else
            {

                Saldo -= valor;

            }

        }

        public void DepositarDinheiro(double valor)
        {

            Saldo += valor;

        }

    }

    class Program
    {
        static void Main()
        {
            int numeroconta = 100;
            double saldo = 0;

            ContaBancaria conta = new ContaBancaria(numeroconta, saldo);

            conta.DepositarDinheiro(500);

            Console.WriteLine(conta.Saldo);

            conta.SacarDinheiro(300);

            Console.WriteLine(conta.Saldo);

            conta.DepositarDinheiro(700);

            Console.WriteLine(conta.Saldo);
        }
    }
}
