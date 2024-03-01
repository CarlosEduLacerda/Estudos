using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Projeto_POO
{
    public class ContaPoupanca : ContaCorrente
    {
        public ContaPoupanca(int numero) : base(numero)
        {
        }

        public void MostrarNumeroDaConta()
        {
            Console.WriteLine($"O número da sua Conta Poupança é: {this.NumeroContaCorrente}");
        }
    }
}
