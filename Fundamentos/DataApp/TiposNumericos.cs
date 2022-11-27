using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class TiposNumericos
    {
        public void Executa()
        {
            //byte 8bits
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            //sbyte
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            //short - 16bits
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            //ushort - 16bits
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            //Int16 - 16bits
            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(Int16.MaxValue);

            //int - 32bits
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            //uint - 32bit
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            //long - 64bits
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            //ulong - 64bits
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
        }
    }
}
