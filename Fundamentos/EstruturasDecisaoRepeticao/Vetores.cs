using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class Vetores
    {
        public static void Teste()
        {
            int[] dias = new int[7];
            dias[0] = 1;
            dias[1] = 2;
            dias[2] = 3;
            dias[3] = 4;
            dias[4] = 5;
            dias[5] = 6;
            dias[6] = 7;

            // erro
            dias[7] = 8;
        }
        public static void Executa()
        {
            string[] dias = new string[7];
            dias[0] = "Domingo";
            dias[1] = "Segunda";
            dias[2] = "Terça";
            dias[3] = "Quarta";
            dias[4] = "Quinta";
            dias[5] = "Sexta";
            dias[6] = "Sábado";

            Console.Write("Digite um numero de 0 a 6:");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dias[index]);
        }
    }
}
