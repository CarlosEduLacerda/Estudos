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
        int resultado;

        while (escolha != "Sim")
        {
            string numero;
            do
            {
                Console.Clear();
                Console.Write("De qual número deseja receber a tabuada? ");
                numero = Console.ReadLine();

                if (!NumericCheck(numero))
                {
                    Console.Write("\nNúmero inválido. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                }
            } while (!NumericCheck(numero));
            int novoNumero = int.Parse(numero);

            string tamanho;
            do
            {
                Console.Clear();
                Console.Write("Até qual multiplicador deseja receber? ");
                tamanho = Console.ReadLine();
                Console.WriteLine();

                if (!NumericCheck(tamanho))
                {
                    Console.Write("\nTamanho inválido. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                }
            } while (!NumericCheck(tamanho));
            int novoTamanho = int.Parse(tamanho);

            for (int i = 0; i < novoTamanho + 1; i++)
            {
                resultado = novoNumero * i;
                Console.WriteLine($"{novoNumero} * {i} = {resultado}");
            }

            Console.WriteLine("\nEm seguida estão filtrados os resultados pares:\n");
            for (int i = 0; i < novoTamanho + 1; i++)
            {
                resultado = novoNumero * i;
                if (resultado % 2 == 0)
                {
                    Console.WriteLine($"{novoNumero} * {i} = {resultado}");
                }
            }

            Console.WriteLine("\nEm seguida estão filtrados os resultados ímpares:\n");
            for (int i = 0; i < novoTamanho + 1; i++)
            {
                resultado = novoNumero * i;
                if (resultado % 2 == 1)
                {
                    Console.WriteLine($"{novoNumero} * {i} = {resultado}");
                }
            }

            Console.Write("\nDigite 'Sim' caso queira sair\n\nDeseja sair? ");
            escolha = Console.ReadLine();
            escolha = escolha.ToLower();
            escolha = char.ToUpper(escolha[0]) + escolha.Substring(1);
            Console.Clear();
        }
        Console.Write("\nObrigado por utilizar o nosso programa!\n\nPressione qualquer tecla para prosseguir...");
        Console.ReadKey();
    }
}