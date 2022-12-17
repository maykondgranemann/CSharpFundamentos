using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class EstruturaDeRepeticao2
    {
        public static void Executa()
        {
            bool continua = false;
            int soma = 0;
            do
            {
                soma += 1;
                Console.WriteLine($"Valor da soma: {soma}");

                Console.Write("Deseja continuar?(S/N)");
                string resposta = Console.ReadLine();
                //if (resposta == "S" || resposta == "s")
                if(resposta.ToUpper() == "S")
                {
                    continua = true;
                }
                else
                {
                    continua = false;
                }

            } while (continua);
        }
    }
}
