class Program
{
    static void Main()
    {
        string x = "abc";
        bool resposta;

        string escolha = "Não";
        string nomePessoa = "";

        while (escolha != "Sim")
        {
            while (nomePessoa.Length < 3)
            {
                Console.Write("Digite seu nome: ");
                nomePessoa = Console.ReadLine();
                resposta = int.TryParse(x, out _);
                Console.Write(resposta);
                Console.Clear();
                if (nomePessoa.Length < 3 || int.TryParse(nomePessoa, out _))
                {
                    Console.Write("Nome inválido. Tente novamente.\n\n");
                }
            }

            nomePessoa = nomePessoa.ToLower();
            nomePessoa = char.ToUpper(nomePessoa[0]) + nomePessoa.Substring(1);

            Console.Write($"Bem-vindo(a), {nomePessoa}!");

            Console.Write("\n\nDigite o primeiro número: ");
            string x = Console.ReadLine();
            double xInfo = Convert.ToDouble(x);

            Console.Write("\nDigite o segundo número: ");
            string y = Console.ReadLine();
            double yInfo = Convert.ToDouble(y);

            double soma = xInfo + yInfo;
            double subtracao = xInfo - yInfo;
            double multiplicacao = xInfo * yInfo;
            double divisao = xInfo / yInfo;

            if (x == "0" && y == "0")
            {
                divisao = 0;
            }

            divisao = Math.Round(divisao, 2);

            Console.WriteLine($"\nOlá, {nomePessoa}!\n\nReferente aos números que me passou ({xInfo} e {yInfo}):\n\n" +
                $"O resultado da soma será: {xInfo} + {yInfo} = {soma}\n" +
                $"O resultado da subtração será: {xInfo} - {yInfo} = {subtracao}\n" +
                $"O resultado da multiplicação será: {xInfo} * {yInfo} = {multiplicacao}\n" +
                $"O resultado da divisão será: {xInfo} / {yInfo} = {divisao}\n");

            Console.Write("Digite 'Sim' caso queira sair\n\nDeseja sair? ");
            escolha = Console.ReadLine();
            escolha = escolha.ToLower();
            escolha = char.ToUpper(escolha[0]) + escolha.Substring(1);
            Console.Clear();

            xInfo = 0; yInfo = 0;
            nomePessoa = "";
        }

        Console.Write("\nObrigado por utilizar o nosso programa!\n\nPressione qualquer tecla para prosseguir...");
        Console.ReadKey();
    }
}