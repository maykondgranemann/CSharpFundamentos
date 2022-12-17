using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class EstruturaDecisao1
    {
        public static void Executa()
        {
            Console.WriteLine("Digite sua idade: ");
            string idadeConsole = Console.ReadLine();
            // Conversao de string para Byte com Convert
            byte idade = Convert.ToByte(idadeConsole);

            // SE 
            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }//SENAO
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
