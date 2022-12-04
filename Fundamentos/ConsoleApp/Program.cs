using DataApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Aula 4");
            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.SetIdade(18);
            //pessoa1.SetNome("Maykon");
            //Console.WriteLine(
            //                   $" \t idade:{pessoa1.GetIdade()}\n" +
            //                    $" \t nome: {pessoa1.GetNome()}"
            //                );

            //TiposNumericos tn = new TiposNumericos();
            //tn.Executa();

            //TiposNumericos2.Executa();

            //TiposNumericos3.Executa();

            Animal animal1 = new Animal();
            animal1.Id = 1;
            animal1.Especie = "Tigre";
            animal1.Habitat = "Savana";

            Console.WriteLine(animal1.Especie);

            Animal animal2 = animal1;
            animal2.Id = 11;
            animal2.Especie = "Gato";
            animal2.Habitat = "Casa";

            Console.WriteLine(animal2.Especie);
            Console.WriteLine(animal1.Especie);
            Console.WriteLine("\n Carros ++++");

            Carro carro1 = new Carro();
            carro1.Id = 2;
            carro1.Marca = "Jaguar";
            carro1.Modelo = "XE";
            Console.WriteLine(carro1.Marca);

            Carro carro2 = carro1;
            carro2.Id = 21;
            carro2.Marca = "Ford";
            carro2.Modelo = "Focus";
            Console.WriteLine(carro2.Marca);
            Console.WriteLine(carro1.Marca);




            Console.ReadLine();
        }
    }
}
