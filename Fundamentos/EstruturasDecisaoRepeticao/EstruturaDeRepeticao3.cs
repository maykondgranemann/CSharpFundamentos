using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class EstruturaDeRepeticao3
    {
        public static void Executa()
        {
            //Para, valor inicial, condicao de repeticao, incremento
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
