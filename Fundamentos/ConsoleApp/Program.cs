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
            Console.WriteLine("Aula 4");
            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.SetIdade(18);
            //pessoa1.SetNome("Maykon");
            //Console.WriteLine(
            //                   $" \t idade:{pessoa1.GetIdade()}\n" +
            //                    $" \t nome: {pessoa1.GetNome()}"
            //                );

            TiposNumericos tn = new TiposNumericos();
            //tn.Executa();

            //TiposNumericos2.Executa();

            TiposNumericos3.Executa();

            Console.ReadLine();
        }
    }
}
