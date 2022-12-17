using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class Listas
    {
        public static void Executa()
        {
            // Vetor com tamanho maximo pré-definido
            string[] dias = new string[7];
            dias[0] = "Domingo";

            // Lista é de tamanho dinâmico
            List<string> nomes = new List<string>();
            // adiciona o valor ao final da lista
            nomes.Add("Maykon");
            nomes.Add("Chimbinha");
            nomes.Add("Joelma");

            Console.WriteLine(nomes[2]);
        }
    }
}
