using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEstruturas
{
    internal class CrudNomes
    {
        List<string> Nomes = new List<string>();
        public void Cadastrar()
        {
            Console.WriteLine("Cadastrando ...");
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();
            Nomes.Add(nome);
        }
        public void Listar()
        {
            Console.WriteLine("Listando Nomes ...");
            foreach (string nome in Nomes)
            {
                Console.WriteLine(nome);
            }
        }
        public void Alterar()
        {
            Console.WriteLine("Dados salvos:");
            Listar();
            Console.Write("Qual nome deseja alterar?");
            string nomeAntigo = Console.ReadLine();
            Console.Write("Digite o novo nome:");
            string nomeNovo = Console.ReadLine();
            Nomes.Remove(nomeAntigo);
            Nomes.Add(nomeNovo);
            Console.WriteLine("Dado alterado com sucesso!");
        }
        public void Alterar2()
        {
            Console.WriteLine("Dados salvos:");
            int posicao = ListarPorPosicao();
            Console.Write("Digite o novo nome:");
            string nomeNovo = Console.ReadLine();
            Nomes[posicao] = nomeNovo;
            Console.WriteLine("Dado alterado com sucesso!");
        }
        public void Deletar()
        {
            Console.WriteLine("Deletando ...");
            int posicao = ListarPorPosicao();
            Nomes.RemoveAt(posicao);
            Console.WriteLine("Dado deletado com sucesso!");
        }

        public int ListarPorPosicao()
        {
            for (int i = 0; i < Nomes.Count; i++)
            {
                Console.WriteLine($"{i} - {Nomes[i]}");
            }
            Console.Write("Digite o numero do dado a ser alterardo:");
            int posicao = Convert.ToInt32(Console.ReadLine());
            return posicao;
        }
    }
}
