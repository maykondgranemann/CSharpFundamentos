using AtividadeEstruturas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtividadeEstruturas
{
    internal class ViewTelaInicial
    {
        PessoaRepository repository = new PessoaRepository();
        public void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("========== Cadastro de pessoas ==========\n");
            Console.WriteLine("\t1 - Cadastrar");
            Console.WriteLine("\t2 - Listar");
            Console.WriteLine("\t3 - Alterar");
            Console.WriteLine("\t4 - Deletar");
            Console.Write("\nEscolha uma das opçÕes do menu:");
        }
        public byte LerOpcao()
        {
            byte opcao = 0;
            try
            {
                opcao = Convert.ToByte(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Dado invalido!");
                Thread.Sleep(1500);
            }
            return opcao;
        }
        public void EscolherOpcao(byte opcao)
        {
            
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Cadastrando ...");
                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();
                    repository.Cadastrar(nome);
                    break;
                case 2:
                    Console.WriteLine("Listando Nomes ...");                    
                    foreach (string item in repository.Listar())
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 3:
                    Console.WriteLine("Dados salvos:");
                    int posicao = ListarPorPosicao(repository.Listar());
                    Console.Write("Digite o novo nome:");
                    string nomeNovo = Console.ReadLine();
                    repository.Alterar(posicao, nomeNovo);
                    Console.WriteLine("Dado alterado com sucesso!");
                    break;
                case 4:
                    Console.WriteLine("Deletando ...");
                    posicao = ListarPorPosicao(repository.Listar());
                    repository.Deletar(posicao);
                    Console.WriteLine("Dado deletado com sucesso!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(1500);
                    break;
            }
        }

        public bool PerguntarNovaOperacao(byte opcao)
        {
            bool continua=false;

            if (opcao > 0 && opcao < 5)
            {
                Console.Write("Deseja realizar outra operação?(S/N)");
                string opcaoContinuar = Console.ReadLine();
                if (opcaoContinuar.ToUpper() == "S")
                {
                    continua = true;
                }
                else
                {
                    continua = false;
                }
            }
            return continua;
        }

        public int ListarPorPosicao(List<string> listaNomes)
        {
            for (int i = 0; i < listaNomes.Count; i++)
            {
                Console.WriteLine($"{i} - {listaNomes[i]}");
            }
            Console.Write("Digite o numero do dado a ser alterardo:");
            int posicao = Convert.ToInt32(Console.ReadLine());
            return posicao;
        }
    }
}
