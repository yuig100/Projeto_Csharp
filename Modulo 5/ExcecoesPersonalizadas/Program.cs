/*
 
Crie uma exceção personalizada chamada SaldoInsuficienteException. 
Em um programa de simulação bancária, lance essa exceção quando uma tentativa de saque deixar o 
saldo negativo.
 
*/

using System;

namespace MeuProjeto
{

    // Definindo a exceção personalizada
    class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base("Saldo insuficiente para o saque.") { }
    }

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
                throw new SaldoInsuficienteException(); // Lançar a exceção personalizada
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

            conta.SacarDinheiro(600);

            Console.WriteLine(conta.Saldo);

            conta.DepositarDinheiro(700);

            Console.WriteLine(conta.Saldo);
        }
    }
}

