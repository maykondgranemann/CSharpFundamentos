using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class TiposNumericos2
    {
        public static void Executa()
        {
            char letra = 'D';
            Console.WriteLine(letra);

            //char - 16bits
            Console.WriteLine(char.MinValue);
            Console.WriteLine(char.MaxValue);

            Console.WriteLine((ushort)char.MinValue);
            Console.WriteLine((ushort)char.MaxValue);

            Console.WriteLine((ushort)letra);
        }
    }
}
