/*
 
Crie uma classe ContaBancaria com propriedades para armazenar saldo e número da conta. 
Adicione métodos para depositar e sacar dinheiro, tomando cuidado para não permitir 
saques que deixem o saldo negativo.
 
*/

using System;

namespace MeuProjeto
{

    class ContaBancaria
    {

        public int Numeroconta;
        public double Saldo;

        public ContaBancaria(int numeroconta,double saldo)
        {

            Saldo = saldo;
            Numeroconta = numeroconta;

        }

        public void SacarDinheiro(double valor)
        {
            if(valor > Saldo)
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
            double saldo = 0 ;

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
