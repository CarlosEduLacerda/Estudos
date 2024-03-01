using ConsumindoApiAluno.Entities;
using ConsumindoApiAluno.Entities.Services;

namespace ConsumindoApiAluno
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string resposta = "Não";

            Console.Write("Informe o id: ");
            int id = int.Parse(Console.ReadLine());

            AlunoServices alunoServices = new AlunoServices();

            Aluno alunoEncontrado = await alunoServices.Integracao(id);

            if (!alunoEncontrado.Verificacao)
            {
                Console.WriteLine("Aluno Encontrado!");

                Console.WriteLine($"Nome: {alunoEncontrado.Nome}");
                Console.WriteLine($"Matrícula: {alunoEncontrado.Matricula}");
                Console.WriteLine($"Situação: {alunoEncontrado.Situacao}");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");

                Console.Write("\nDeseja adiciona-lo(a)? ");
                resposta = Console.ReadLine();
                resposta = resposta.ToLower();
                resposta = char.ToUpper(resposta[0]) + resposta.Substring(1);
                if (resposta == "Sim")
                {
                    Console.Write("\nDigite o nome do novo aluno: ");
                    string nomeNovoAluno = Console.ReadLine();

                    Console.Write("\nDigite a matrícula do novo aluno: ");
                    int matriculaNovoAluno = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite a situação do novo aluno: ");
                    string situacaoNovoAluno = Console.ReadLine();

                    //AlunoRepository repository = new AlunoRepository();
                    //repository.AdicionarAluno(nomeNovoAluno, situacaoNovoAluno, matriculaNovoAluno);
                }
                else
                {
                    Console.WriteLine("\nObrigado por utilizar o nosso programa");
                }
            }
        }
    }
}
