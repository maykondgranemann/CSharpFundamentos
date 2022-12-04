using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp
{
    public class Animal // Tipo por referência
    {
        public int Id { get; set; }
        public string Especie { get; set; }
        public string Habitat { get; set; }

        public int GetId()
        {
            return this.Id;
        }
    }

    public struct Carro // Tipo por valor
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public int GetId() 
        {
            return this.Id;
        }
    }
}
