using DataApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto
{
    public partial class Form1 : Form
    {
        public List<Produto> ListaProduto { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.ListaProduto = new List<Produto>();
            CarregaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void LimparTela()
        {
            this.txtId.Text = String.Empty;
            this.txtNome.Text = String.Empty;
            this.txtTipo.Text = String.Empty;
            this.txtValor.Text = String.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Criar uma instancia de produto
            Produto produto = new Produto();
            produto.Id = Convert.ToInt32(this.txtId.Text);
            produto.Nome = this.txtNome.Text;
            produto.Tipo = this.txtTipo.Text;
            produto.Valor = Convert.ToDecimal(this.txtValor.Text);
            // Adicionar a lista de produto
            this.ListaProduto.Add(produto);
            // Limpar a tela
            this.LimparTela();

            //Carregar Grid
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            this.dgProdutos.DataSource = null;
            this.dgProdutos.DataSource = this.ListaProduto;
        }
    }
}
