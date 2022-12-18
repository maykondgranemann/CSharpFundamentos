using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeEstruturas.Data
{
    public class PessoaRepository
    {
        List<Pessoa> Pessoas = new List<Pessoa>();
        static int id = 0;

        public void Cadastrar(Pessoa pessoa)
        {
            id++;
            pessoa.Id = id;
            Pessoas.Add(pessoa);
        }
        public List<Pessoa> Listar()
        {
            return Pessoas;
        }

        public Pessoa ListarPorId(int id)
        {
            Pessoa pessoa = new Pessoa();
            foreach (var item in Pessoas)
            {
                if(item.Id == id)
                {
                    pessoa = item;
                }
            }
            return pessoa;
        }
        public void Alterar(Pessoa pessoa)
        {
            foreach (Pessoa item in Pessoas)
            {
                if(item.Id == pessoa.Id)
                {
                    item.Nome = pessoa.Nome;
                }
            }
        }
        public void Deletar(int id)
        {
            Pessoa pessoa = new Pessoa();
            foreach(Pessoa item in Pessoas)
            {
                if(item.Id == id)
                {
                    pessoa = item;
                }
            }
            Pessoas.Remove(pessoa);
        }
    }
}
