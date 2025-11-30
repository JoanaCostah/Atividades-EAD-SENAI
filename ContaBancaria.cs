using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class ContaBancaria
    {
        public string NumeroConta { get; set; }

        public double Saldo { get; set; } = 1000;
        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
                Console.WriteLine("Depósito de R$" + valorDeposito + " realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Sacar(double valorSaque)
        {
            if (valorSaque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }

            else if (valorSaque > 0)
            {

                Saldo -= valorSaque;
                Console.WriteLine("Saque de R$" + valorSaque + " realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido.");
            }

            
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo atual é de R$" + Saldo);
        }
    }
}