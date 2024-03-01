namespace Teste_Projeto_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int numContaC = aleatorio.Next();
            string nomeClient;

            int numContaP = aleatorio.Next();

            ContaCorrente conta = new ContaCorrente(numContaC);

            CartaoDeCredito qualquerUm = new CartaoDeCredito();
            Cliente c = new Cliente();
            ContaPoupanca contaPoupanca = new ContaPoupanca(numContaP);

            Console.Write("Digite seu nome: ");
            nomeClient = Console.ReadLine();

            nomeClient = nomeClient.ToLower();
            nomeClient = char.ToUpper(nomeClient[0]) + nomeClient.Substring(1);

            c.Nome = nomeClient;
            qualquerUm.Numero = "234567897654";
            qualquerUm.DataDeValidade = "08/2001";
            qualquerUm.Cliente = c;

            Console.Write("\nDigite o valor que deseja depositar na conta corrente: ");
            double depositCorrente = double.Parse(Console.ReadLine());
            conta.Deposito(depositCorrente);

            Console.Write("\nDigite o valor que deseja depositar na conta poupança: ");
            double depositPoupanca = double.Parse(Console.ReadLine());
            contaPoupanca.Deposito(depositPoupanca);

            Console.Write("\nDigite o valor que deseja sacar (Conta Corrente): ");
            double sacar = double.Parse(Console.ReadLine());
            bool saca = conta.Saque(sacar);

            Console.Write("\nDigite o valor que deseja sacar (Conta Poupança): ");
            double sacarPoupanca = double.Parse(Console.ReadLine());
            bool sacaPoupanca = contaPoupanca.Saque(sacarPoupanca);

            double saldoPoupanca = contaPoupanca.ConsultaSaldoDisponivel();

            conta.AdicionarLimite(1000);

            if (saca)
            {
                Console.WriteLine("Teste Simulador Bancário - POO");
                double saldo = conta.ConsultaSaldoDisponivel();
                Console.Clear();
                Console.WriteLine($"Bem-vindo, {c.Nome}");

                Console.WriteLine($"\nSeu saldo atual na Conta Corrente é de: R$ {Math.Round(saldo, 2)}");
                Console.WriteLine($"Seu saldo atual na Conta Poupança é de: R$ {Math.Round(saldoPoupanca, 2)}");
                Console.WriteLine($"Seu limite é de: R$ {Math.Round(conta.Limite, 2)}");
                Console.WriteLine($"O número do seu cartão de débito é: {conta.NumeroContaCorrente}");
                contaPoupanca.MostrarNumeroDaConta();
                Console.WriteLine($"O número do seu cartão de crédito é: {qualquerUm.Numero}");
                Console.WriteLine($"O data de validade do seu cartão de crédito é: {qualquerUm.DataDeValidade}\n");
                Console.WriteLine($"Até mais, {qualquerUm.Cliente.Nome}");

                Console.WriteLine($"Com você nosso número total de contas é: {ContaCorrente.TotalContasCriadas}");
            }
        }
    }
}
