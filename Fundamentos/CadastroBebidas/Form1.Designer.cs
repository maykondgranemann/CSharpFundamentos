namespace CadastroBebidas
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(143, 72);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(131, 97);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(28, 13);
            this.lbTipo.TabIndex = 1;
            this.lbTipo.Text = "Tipo";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(122, 126);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 2;
            this.lbMarca.Text = "Marca";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(128, 155);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 3;
            this.lbValor.Text = "Valor";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(174, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(174, 97);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(156, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(174, 124);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(156, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(174, 155);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(156, 20);
            this.txtValor.TabIndex = 7;
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.bntSalvar.Location = new System.Drawing.Point(174, 196);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 8;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = false;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(255, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(171, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(159, 13);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Sistema de cadastro de Bebidas";
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Location = new System.Drawing.Point(47, 240);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.Size = new System.Drawing.Size(715, 150);
            this.dgBebidas.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbId);
            this.Name = "Form1";
            this.Text = "Tipo";
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgBebidas;
    }
}

