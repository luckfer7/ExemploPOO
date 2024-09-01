using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente (int numeroConta, decimal SaldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = SaldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else 
            {
                Console.WriteLine($"Valor desejado é maior que o saldo disponível");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo disponível é de R$ {saldo}.");
        }
    }
    
}