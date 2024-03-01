using AlunoApi.Entities;

namespace AlunoApi.Repository
{
    public class AlunoRepository
    {
        public static List<Aluno> BancodeDadosFake { get; set; } = new List<Aluno>();

        public void Carga()
        {
            Aluno aluno1 = new Aluno(1, "Carlos1", "Matriculado", 12345);
            Aluno aluno2 = new Aluno(2, "Carlos2", "Matriculado", 54321);
            Aluno aluno3 = new Aluno(3, "Carlos3", "Cancelado", 13245);
            Aluno aluno4 = new Aluno(4, "Carlos4", "Trancado", 15243);

            BancodeDadosFake.Add(aluno1);
            BancodeDadosFake.Add(aluno2);
            BancodeDadosFake.Add(aluno3);
            BancodeDadosFake.Add(aluno4);
        }
        public void AdicionarAluno(string nome, string situacao, int matricula)
        {
            int novoId = BancodeDadosFake.Count + 1;
            Aluno novoAluno = new Aluno(novoId, nome, situacao, matricula);
            BancodeDadosFake.Add(novoAluno);
            Console.WriteLine("Aluno adicionado com sucesso!");
        }
    }
}
