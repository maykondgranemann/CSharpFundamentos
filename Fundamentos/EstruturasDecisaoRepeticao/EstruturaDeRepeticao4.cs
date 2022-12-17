using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class EstruturaDeRepeticao4
    {
        public static void Executa()
        {
            List<string> cervejas = new List<string>();
            cervejas.Add("Spaten");
            cervejas.Add("Patrícia");
            cervejas.Add("Corona");

            //Imprimir a lista com um For tradicional
            for (int i = 0; i < cervejas.Count; i++)
            {
                //Console.WriteLine(cervejas[i]);
                Console.WriteLine($" {i} - {cervejas[i]} ");
            }

            //Imprimir a lista com o ForEach
            foreach (var item in cervejas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
