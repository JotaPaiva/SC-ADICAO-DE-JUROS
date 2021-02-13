namespace EstagiarioSimcred
{
    partial class calculadoraJuros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpEntradas = new System.Windows.Forms.GroupBox();
            this.txtValorOriginal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorJuros = new System.Windows.Forms.TextBox();
            this.lblFatura = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.grpValores = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtParcelas1X = new System.Windows.Forms.TextBox();
            this.txtParcelas2X = new System.Windows.Forms.TextBox();
            this.txtParcelas3X = new System.Windows.Forms.TextBox();
            this.txtParcelas4X = new System.Windows.Forms.TextBox();
            this.txtParcelas5X = new System.Windows.Forms.TextBox();
            this.txtTotal1X = new System.Windows.Forms.TextBox();
            this.txtTotal2X = new System.Windows.Forms.TextBox();
            this.txtTotal3X = new System.Windows.Forms.TextBox();
            this.txtTotal4X = new System.Windows.Forms.TextBox();
            this.txtTotal5X = new System.Windows.Forms.TextBox();
            this.lblIgual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lbl1x = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpEntradas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEntradas
            // 
            this.grpEntradas.Controls.Add(this.lblFatura);
            this.grpEntradas.Controls.Add(this.txtValorOriginal);
            this.grpEntradas.Location = new System.Drawing.Point(12, 4);
            this.grpEntradas.Name = "grpEntradas";
            this.grpEntradas.Size = new System.Drawing.Size(113, 63);
            this.grpEntradas.TabIndex = 0;
            this.grpEntradas.TabStop = false;
            // 
            // txtValorOriginal
            // 
            this.txtValorOriginal.Location = new System.Drawing.Point(12, 30);
            this.txtValorOriginal.Name = "txtValorOriginal";
            this.txtValorOriginal.Size = new System.Drawing.Size(89, 20);
            this.txtValorOriginal.TabIndex = 1;
            this.txtValorOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblJuros);
            this.groupBox1.Controls.Add(this.txtValorJuros);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtValorJuros
            // 
            this.txtValorJuros.Location = new System.Drawing.Point(12, 31);
            this.txtValorJuros.Name = "txtValorJuros";
            this.txtValorJuros.Size = new System.Drawing.Size(89, 20);
            this.txtValorJuros.TabIndex = 2;
            this.txtValorJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFatura
            // 
            this.lblFatura.AutoSize = true;
            this.lblFatura.Location = new System.Drawing.Point(22, 14);
            this.lblFatura.Name = "lblFatura";
            this.lblFatura.Size = new System.Drawing.Size(72, 13);
            this.lblFatura.TabIndex = 3;
            this.lblFatura.Text = "Valor Original:";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(26, 14);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(61, 13);
            this.lblJuros.TabIndex = 4;
            this.lblJuros.Text = "% de Juros:";
            // 
            // grpValores
            // 
            this.grpValores.BackColor = System.Drawing.SystemColors.Control;
            this.grpValores.Controls.Add(this.label8);
            this.grpValores.Controls.Add(this.label7);
            this.grpValores.Controls.Add(this.label6);
            this.grpValores.Controls.Add(this.label5);
            this.grpValores.Controls.Add(this.lbl1x);
            this.grpValores.Controls.Add(this.label4);
            this.grpValores.Controls.Add(this.label3);
            this.grpValores.Controls.Add(this.label2);
            this.grpValores.Controls.Add(this.label1);
            this.grpValores.Controls.Add(this.lblIgual);
            this.grpValores.Controls.Add(this.txtTotal5X);
            this.grpValores.Controls.Add(this.txtTotal4X);
            this.grpValores.Controls.Add(this.txtTotal3X);
            this.grpValores.Controls.Add(this.txtTotal2X);
            this.grpValores.Controls.Add(this.txtTotal1X);
            this.grpValores.Controls.Add(this.txtParcelas5X);
            this.grpValores.Controls.Add(this.txtParcelas4X);
            this.grpValores.Controls.Add(this.txtParcelas3X);
            this.grpValores.Controls.Add(this.txtParcelas2X);
            this.grpValores.Controls.Add(this.txtParcelas1X);
            this.grpValores.Location = new System.Drawing.Point(131, 4);
            this.grpValores.Name = "grpValores";
            this.grpValores.Size = new System.Drawing.Size(224, 157);
            this.grpValores.TabIndex = 3;
            this.grpValores.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Location = new System.Drawing.Point(12, 138);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(54, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "=";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtParcelas1X
            // 
            this.txtParcelas1X.BackColor = System.Drawing.SystemColors.Window;
            this.txtParcelas1X.Enabled = false;
            this.txtParcelas1X.Location = new System.Drawing.Point(30, 19);
            this.txtParcelas1X.Name = "txtParcelas1X";
            this.txtParcelas1X.Size = new System.Drawing.Size(84, 20);
            this.txtParcelas1X.TabIndex = 5;
            this.txtParcelas1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcelas2X
            // 
            this.txtParcelas2X.BackColor = System.Drawing.SystemColors.Window;
            this.txtParcelas2X.Enabled = false;
            this.txtParcelas2X.Location = new System.Drawing.Point(30, 45);
            this.txtParcelas2X.Name = "txtParcelas2X";
            this.txtParcelas2X.Size = new System.Drawing.Size(84, 20);
            this.txtParcelas2X.TabIndex = 6;
            this.txtParcelas2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcelas3X
            // 
            this.txtParcelas3X.BackColor = System.Drawing.SystemColors.Window;
            this.txtParcelas3X.Enabled = false;
            this.txtParcelas3X.Location = new System.Drawing.Point(30, 71);
            this.txtParcelas3X.Name = "txtParcelas3X";
            this.txtParcelas3X.Size = new System.Drawing.Size(84, 20);
            this.txtParcelas3X.TabIndex = 7;
            this.txtParcelas3X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcelas4X
            // 
            this.txtParcelas4X.BackColor = System.Drawing.SystemColors.Window;
            this.txtParcelas4X.Enabled = false;
            this.txtParcelas4X.Location = new System.Drawing.Point(30, 97);
            this.txtParcelas4X.Name = "txtParcelas4X";
            this.txtParcelas4X.Size = new System.Drawing.Size(84, 20);
            this.txtParcelas4X.TabIndex = 8;
            this.txtParcelas4X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcelas5X
            // 
            this.txtParcelas5X.BackColor = System.Drawing.SystemColors.Window;
            this.txtParcelas5X.Enabled = false;
            this.txtParcelas5X.Location = new System.Drawing.Point(30, 123);
            this.txtParcelas5X.Name = "txtParcelas5X";
            this.txtParcelas5X.Size = new System.Drawing.Size(84, 20);
            this.txtParcelas5X.TabIndex = 9;
            this.txtParcelas5X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal1X
            // 
            this.txtTotal1X.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal1X.Enabled = false;
            this.txtTotal1X.Location = new System.Drawing.Point(139, 19);
            this.txtTotal1X.Name = "txtTotal1X";
            this.txtTotal1X.Size = new System.Drawing.Size(72, 20);
            this.txtTotal1X.TabIndex = 10;
            this.txtTotal1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal2X
            // 
            this.txtTotal2X.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal2X.Enabled = false;
            this.txtTotal2X.Location = new System.Drawing.Point(139, 45);
            this.txtTotal2X.Name = "txtTotal2X";
            this.txtTotal2X.Size = new System.Drawing.Size(72, 20);
            this.txtTotal2X.TabIndex = 11;
            this.txtTotal2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal3X
            // 
            this.txtTotal3X.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal3X.Enabled = false;
            this.txtTotal3X.Location = new System.Drawing.Point(139, 71);
            this.txtTotal3X.Name = "txtTotal3X";
            this.txtTotal3X.Size = new System.Drawing.Size(72, 20);
            this.txtTotal3X.TabIndex = 12;
            this.txtTotal3X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal4X
            // 
            this.txtTotal4X.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal4X.Enabled = false;
            this.txtTotal4X.Location = new System.Drawing.Point(139, 97);
            this.txtTotal4X.Name = "txtTotal4X";
            this.txtTotal4X.Size = new System.Drawing.Size(72, 20);
            this.txtTotal4X.TabIndex = 13;
            this.txtTotal4X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal5X
            // 
            this.txtTotal5X.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal5X.Enabled = false;
            this.txtTotal5X.Location = new System.Drawing.Point(139, 123);
            this.txtTotal5X.Name = "txtTotal5X";
            this.txtTotal5X.Size = new System.Drawing.Size(72, 20);
            this.txtTotal5X.TabIndex = 14;
            this.txtTotal5X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(121, 22);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 5;
            this.lblIgual.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "=";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(71, 138);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(54, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lbl1x
            // 
            this.lbl1x.AutoSize = true;
            this.lbl1x.Location = new System.Drawing.Point(8, 22);
            this.lbl1x.Name = "lbl1x";
            this.lbl1x.Size = new System.Drawing.Size(18, 13);
            this.lbl1x.TabIndex = 6;
            this.lbl1x.Text = "1x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "2x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "3x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "4x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "5x";
            // 
            // calculadoraJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(367, 173);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpValores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEntradas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 212);
            this.Name = "calculadoraJuros";
            this.ShowIcon = false;
            this.Text = "Calculadora de Juros";
            this.Load += new System.EventHandler(this.calculadoraJuros_Load);
            this.grpEntradas.ResumeLayout(false);
            this.grpEntradas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpValores.ResumeLayout(false);
            this.grpValores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntradas;
        private System.Windows.Forms.Label lblFatura;
        private System.Windows.Forms.TextBox txtValorOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtValorJuros;
        private System.Windows.Forms.GroupBox grpValores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.TextBox txtTotal5X;
        private System.Windows.Forms.TextBox txtTotal4X;
        private System.Windows.Forms.TextBox txtTotal3X;
        private System.Windows.Forms.TextBox txtTotal2X;
        private System.Windows.Forms.TextBox txtTotal1X;
        private System.Windows.Forms.TextBox txtParcelas5X;
        private System.Windows.Forms.TextBox txtParcelas3X;
        private System.Windows.Forms.TextBox txtParcelas2X;
        private System.Windows.Forms.TextBox txtParcelas1X;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtParcelas4X;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl1x;
    }
}

