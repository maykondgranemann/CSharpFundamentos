using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class Listas2
    {
        public static void Executa()
        {
            // Criando uma lista vazia
            List<string> nomes = new List<string>();
            // Adicionando valores ao final da lista
            nomes.Add("Jojo");
            nomes.Add("Elon");
            nomes.Add("Skol");

            //Remover um valor específico da lista
            nomes.Remove("Elon");

            //Remover um dados em uma posição da lista
            nomes.RemoveAt(0);


            // Criando uma lista com valores iniciais
            List<string> cervejas = new List<string> { "Brahma", "Patrícia" };   
            
            // Adicionando um conjunto de valores / uma lista dentro de outra
            nomes.AddRange(cervejas);
        }
    }
}
