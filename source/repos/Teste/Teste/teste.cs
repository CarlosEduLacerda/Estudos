using System;

class Program
{
    static bool NumericCheck(string s)
    {
        return int.TryParse(s, out _);
    }

    static void Main()
    {
        string escolha = "Não";
        string nomePessoa = "1";

        while (escolha != "Sim")
        {
            while (nomePessoa.Length < 3 || nomePessoa.Length > 10 || NumericCheck(nomePessoa))
            {
                Console.Write("Digite seu primeiro nome (máximo 10 caracteres): ");
                nomePessoa = Console.ReadLine();
                Console.Clear();
                if (nomePessoa.Length < 3 || nomePessoa.Length > 10 || NumericCheck(nomePessoa))
                {
                    Console.Write("Nome inválido. Tente novamente.\n\n");
                }
            }

            nomePessoa = nomePessoa.ToLower();
            nomePessoa = char.ToUpper(nomePessoa[0]) + nomePessoa.Substring(1);

            string x;
            do
            {
                Console.Clear();
                Console.Write($"Bem-vindo(a), {nomePessoa}!");
                Console.Write("\n\nDigite o primeiro número: ");
                x = Console.ReadLine();
                if (!NumericCheck(x))
                {
                    Console.Write("\nNúmero inválido. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                }
            } while (!NumericCheck(x));
            double xInfo = Convert.ToDouble(x);

            string y;
            do
            {
                Console.Clear();
                Console.Write($"Bem-vindo(a), {nomePessoa}!\n\nPrimeiro número: {xInfo}");
                Console.Write("\n\nDigite o segundo número: ");
                y = Console.ReadLine();
                if (!NumericCheck(y))
                {
                    Console.Write("\nNúmero inválido. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                }
            } while (!NumericCheck(y));
            double yInfo = Convert.ToDouble(y);

            double soma = xInfo + yInfo;
            double subtracao = xInfo - yInfo;
            double multiplicacao = xInfo * yInfo;
            double divisao = xInfo / yInfo;

            if (x == "0" || y == "0")
            {
                divisao = 0;
            }

            divisao = Math.Round(divisao, 2);

            Console.Clear();
            Console.WriteLine($"Olá, {nomePessoa}!\n\nReferente aos números que me passou ({xInfo} e {yInfo}):\n\n" +
                $"O resultado da soma será: {xInfo} + {yInfo} = {soma}\n" +
                $"O resultado da subtração será: {xInfo} - {yInfo} = {subtracao}\n" +
                $"O resultado da multiplicação será: {xInfo} * {yInfo} = {multiplicacao}\n" +
                $"O resultado da divisão será: {xInfo} / {yInfo} = {divisao}\n");

            Console.Write("Digite 'Sim' caso queira sair\n\nDeseja sair? ");
            escolha = Console.ReadLine();
            escolha = escolha.ToLower();
            escolha = char.ToUpper(escolha[0]) + escolha.Substring(1);
            Console.Clear();

            nomePessoa = "";
        }

        Console.Write("\nObrigado por utilizar o nosso programa!\n\nPressione qualquer tecla para prosseguir...");
        Console.ReadKey();
    }
}