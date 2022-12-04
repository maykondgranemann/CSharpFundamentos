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

namespace CadastroBebidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Bebida bebida = new Bebida();
            bebida.Id = Convert.ToInt32( txtId.Text );
            bebida.Tipo = txtTipo.Text;
            bebida.Marca = txtMarca.Text;
            bebida.Valor = Convert.ToDecimal( txtValor.Text );

            this.LimpaTela();
        }

        private void LimpaTela()
        {
            txtId.Text = "";
            txtTipo.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtValor.Text = String.Empty;
        }
    }
}
