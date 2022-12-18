using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtividadeEstruturas
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            bool continua = true;
            ViewTelaInicial telaInicial = new ViewTelaInicial();
            do
            {                                
                telaInicial.ImprimirMenu();
                byte opcao = telaInicial.LerOpcao();
                
                if(opcao != 0)
                {
                    telaInicial.EscolherOpcao(opcao);
                    continua = telaInicial.PerguntarNovaOperacao(opcao);
                }    
            } while (continua);
        }        
    }
}
