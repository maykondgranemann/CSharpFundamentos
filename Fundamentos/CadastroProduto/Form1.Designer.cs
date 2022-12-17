namespace CadastroProduto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(287, 24);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(191, 24);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro de Produtos";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(291, 86);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(19, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Id:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(272, 112);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(279, 140);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 3;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(276, 165);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 4;
            this.lbValor.Text = "Valor:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(319, 83);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(319, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(319, 133);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(161, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(319, 158);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(161, 20);
            this.txtValor.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(319, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(405, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(101, 252);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(614, 147);
            this.dgProdutos.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgProdutos;
    }
}

