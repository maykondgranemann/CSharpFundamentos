using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisaoRepeticao
{
    internal class EstruturaDecisao2
    {
        public static void Executa()
        {
            Console.Write("Digite um numero:");
            int dia = 0;
            // Tratamento de exceção
            try
            {
                dia = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Valor digitado não é um número!");
            }        

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
        }
    }
}
