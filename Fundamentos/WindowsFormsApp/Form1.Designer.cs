﻿namespace WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbByteMin = new System.Windows.Forms.Label();
            this.lbByteMax = new System.Windows.Forms.Label();
            this.btnValores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(282, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# Fundamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipos Numericos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Byte MinValue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Byte MaxValue";
            // 
            // lbByteMin
            // 
            this.lbByteMin.AutoSize = true;
            this.lbByteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbByteMin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbByteMin.Location = new System.Drawing.Point(193, 118);
            this.lbByteMin.Name = "lbByteMin";
            this.lbByteMin.Size = new System.Drawing.Size(33, 17);
            this.lbByteMin.TabIndex = 3;
            this.lbByteMin.Text = "*****";
            // 
            // lbByteMax
            // 
            this.lbByteMax.AutoSize = true;
            this.lbByteMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbByteMax.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbByteMax.Location = new System.Drawing.Point(193, 135);
            this.lbByteMax.Name = "lbByteMax";
            this.lbByteMax.Size = new System.Drawing.Size(33, 17);
            this.lbByteMax.TabIndex = 3;
            this.lbByteMax.Text = "*****";
            // 
            // btnValores
            // 
            this.btnValores.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnValores.Location = new System.Drawing.Point(303, 339);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(151, 34);
            this.btnValores.TabIndex = 4;
            this.btnValores.Text = "Mostrar Valores";
            this.btnValores.UseVisualStyleBackColor = false;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.lbByteMax);
            this.Controls.Add(this.lbByteMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbByteMin;
        private System.Windows.Forms.Label lbByteMax;
        private System.Windows.Forms.Button btnValores;
    }
}

