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
        CrudNomes crudNomes = new CrudNomes();
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
                    crudNomes.Cadastrar();
                    break;
                case 2:
                    crudNomes.Listar();
                    break;
                case 3:
                    crudNomes.Alterar2();
                    break;
                case 4:
                    crudNomes.Deletar();
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
    }
}
