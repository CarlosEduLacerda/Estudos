/* Temos 'Name' e 'Solution Name' -> Ambos os nomes devem ser iguais, porém 'Solution Name' é o nome dado a coleção de projetos feitos
 * dentro de 'Name'. Caso 'Name' seja alterado, 'Solution name' também é alterado, mas o contrário não é válido.
 * Com isso, dentro de 'Solution Name' teremos vários projetos (Projects).
 * Namespace (Project) -> Logical Container of Types = Um conteiner lógico de tipos. Sua função é agrupar os itens, ou seja, projeto é uma coleção
 * de itens. Exemplo de item: Classe
 * Temos class que nada mais é do que uma classe, semelhante às classes do Python.
 * Using é utilizado para importar bibliotecas no C#
 * Para criar um novo projeto dentro de uma solução, basta clicar com o botão direito no nome da solução, 'Adicionar' e depois 'Novo Item'
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Básicos_C_
{
    public class Carro(string marca, string modelo, int ano, string cor)
    {
        public string Marca { get; set; } = marca;
        public string Modelo { get; set; } = modelo;
        public int Ano { get; set; } = ano;
        public string Cor { get; set; } = cor;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Fiat", "Uno", 2010, "Amarelo");
            Console.WriteLine($"Seu carro é um {carro1.Modelo}, da marca {carro1.Marca}\nAno {carro1.Ano}\nCor {carro1.Cor}");
        }
    }
}

