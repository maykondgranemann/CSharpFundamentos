using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class EstruturaDeRepeticao1
    {
        public static void Teste()
        {
            //Enquanto
            while (true) // Loop infinito
            {
                Console.WriteLine("Olá");
            }
        }
        public static void Executa()
        {
            bool continua = true;
            int soma = 0;

            while (continua)
            {
                soma += 1;
                Console.WriteLine($"Valor da soma: {soma}");

                Console.Write("Deseja continuar?(S/N)");
                string resposta = Console.ReadLine();
                if(resposta == "N")
                {
                    continua = false;
                }
            }
        }
    }
}
