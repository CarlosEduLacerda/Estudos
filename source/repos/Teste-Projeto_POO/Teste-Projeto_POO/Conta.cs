using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Projeto_POO
{
    public class ContaCorrente
    {
        public ContaCorrente(int numero)
        {
            this.NumeroContaCorrente = numero;
            ContaCorrente.TotalContasCriadas++;
        }
        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int NumeroContaCorrente { get; private set; }
        public static int TotalContasCriadas { get; set; }
        public string Nome { get; set; }
        public double CartaoDebito { get; set; }
        public bool CartaoCredito { get; set; }
        public double Emprestimo { get; set; }
        public double PagamentoRecorrente { get; set; }

        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }
        public bool Saque(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();

            if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this.Saldo -= valor;
            return true;
        }
        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo;
        }
        public void AdicionarLimite(double valor)
        {
            this.Limite += valor;
        }
    }
}
