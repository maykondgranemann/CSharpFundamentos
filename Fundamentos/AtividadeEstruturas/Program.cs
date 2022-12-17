using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtividadeEstruturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            do
            {
                
                Console.Clear();
                Console.WriteLine("========== Cadastro de pessoas ==========\n");
                Console.WriteLine("\t1 - Cadastrar");
                Console.WriteLine("\t2 - Listar");
                Console.WriteLine("\t3 - Alterar");
                Console.WriteLine("\t4 - Deletar");
                Console.Write("\nEscolha uma das opçÕes do menu:");
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
                if(opcao != 0)
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Cadastrando ...");
                            break;
                        case 2:
                            Console.WriteLine("Listando ...");
                            break;
                        case 3:
                            Console.WriteLine("Altarando ...");
                            break;
                        case 4:
                            Console.WriteLine("Deletando ...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            Thread.Sleep(1500);
                            break;
                    }

                    if (opcao>0 && opcao<5)
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
                }
                

               
            } while (continua);
        }
    }
}
