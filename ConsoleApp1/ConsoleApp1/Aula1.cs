using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aula1
    {
        public static void Executar()
        {
            //Console.WriteLine("Olá, mundo");

            Console.Write("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Seja bem-vindo, " + nome);

            Console.Write("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nome + " sua idade é: " + idade);

            //IF é uma estrutura de descisão
            if (idade >= 18)
            {
                Console.WriteLine("Maior de idade");
            }

            if (idade < 18)
            {
                Console.WriteLine("Menor de idade");
            }
            Console.ReadLine();
        }
    }
}
