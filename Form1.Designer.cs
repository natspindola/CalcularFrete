
namespace CalcularFrete
{
    partial class Calcular_Frete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calcular_Frete));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkIdaVolta = new System.Windows.Forms.CheckBox();
            this.checkIda = new System.Windows.Forms.CheckBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.txtKMRodado = new System.Windows.Forms.TextBox();
            this.txtCustoKM = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.cmbTabela = new System.Windows.Forms.ComboBox();
            this.imgFrota = new System.Windows.Forms.PictureBox();
            this.imgVeiculo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA CÁLCULO DE FRETE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distância KM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor combustível:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tabela:";
            // 
            // checkIdaVolta
            // 
            this.checkIdaVolta.AutoSize = true;
            this.checkIdaVolta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkIdaVolta.Location = new System.Drawing.Point(361, 84);
            this.checkIdaVolta.Name = "checkIdaVolta";
            this.checkIdaVolta.Size = new System.Drawing.Size(76, 17);
            this.checkIdaVolta.TabIndex = 6;
            this.checkIdaVolta.Text = "Ida / Volta";
            this.checkIdaVolta.UseVisualStyleBackColor = true;
            // 
            // checkIda
            // 
            this.checkIda.AutoSize = true;
            this.checkIda.Location = new System.Drawing.Point(443, 84);
            this.checkIda.Name = "checkIda";
            this.checkIda.Size = new System.Drawing.Size(41, 17);
            this.checkIda.TabIndex = 7;
            this.checkIda.Text = "Ida";
            this.checkIda.UseVisualStyleBackColor = true;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(174, 37);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(153, 20);
            this.txtLocal.TabIndex = 2;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(333, 37);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(153, 20);
            this.txtDistancia.TabIndex = 3;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Location = new System.Drawing.Point(113, 82);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(92, 20);
            this.txtCombustivel.TabIndex = 4;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(12, 174);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(173, 44);
            this.btnConfirma.TabIndex = 8;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Autonomia de combustível:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Despesa com combustível:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "KM rodado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Custo por KM:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total:";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(214, 82);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(92, 20);
            this.txtConsumo.TabIndex = 9;
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(335, 252);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(153, 20);
            this.txtDespesa.TabIndex = 10;
            // 
            // txtKMRodado
            // 
            this.txtKMRodado.Location = new System.Drawing.Point(12, 252);
            this.txtKMRodado.Name = "txtKMRodado";
            this.txtKMRodado.Size = new System.Drawing.Size(156, 20);
            this.txtKMRodado.TabIndex = 11;
            // 
            // txtCustoKM
            // 
            this.txtCustoKM.Location = new System.Drawing.Point(176, 252);
            this.txtCustoKM.Name = "txtCustoKM";
            this.txtCustoKM.Size = new System.Drawing.Size(153, 20);
            this.txtCustoKM.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(335, 302);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(153, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.txtVeiculo);
            this.panel1.Controls.Add(this.cmbTabela);
            this.panel1.Controls.Add(this.imgFrota);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtConsumo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkIdaVolta);
            this.panel1.Controls.Add(this.checkIda);
            this.panel1.Controls.Add(this.txtLocal);
            this.panel1.Controls.Add(this.txtDistancia);
            this.panel1.Controls.Add(this.txtCombustivel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 131);
            this.panel1.TabIndex = 24;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(10, 37);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(156, 20);
            this.txtVeiculo.TabIndex = 1;
            this.txtVeiculo.TextChanged += new System.EventHandler(this.txtVeiculo_TextChanged);
            // 
            // cmbTabela
            // 
            this.cmbTabela.FormattingEnabled = true;
            this.cmbTabela.Location = new System.Drawing.Point(10, 81);
            this.cmbTabela.Name = "cmbTabela";
            this.cmbTabela.Size = new System.Drawing.Size(92, 21);
            this.cmbTabela.TabIndex = 5;
            // 
            // imgFrota
            // 
            this.imgFrota.Image = ((System.Drawing.Image)(resources.GetObject("imgFrota.Image")));
            this.imgFrota.Location = new System.Drawing.Point(490, 0);
            this.imgFrota.Name = "imgFrota";
            this.imgFrota.Size = new System.Drawing.Size(282, 131);
            this.imgFrota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFrota.TabIndex = 13;
            this.imgFrota.TabStop = false;
            // 
            // imgVeiculo
            // 
            this.imgVeiculo.Location = new System.Drawing.Point(520, 184);
            this.imgVeiculo.Name = "imgVeiculo";
            this.imgVeiculo.Size = new System.Drawing.Size(254, 138);
            this.imgVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVeiculo.TabIndex = 14;
            this.imgVeiculo.TabStop = false;
            // 
            // Calcular_Frete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(783, 332);
            this.Controls.Add(this.imgVeiculo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCustoKM);
            this.Controls.Add(this.txtKMRodado);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.label1);
            this.Name = "Calcular_Frete";
            this.Text = "Calcular frete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkIdaVolta;
        private System.Windows.Forms.CheckBox checkIda;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.TextBox txtKMRodado;
        private System.Windows.Forms.TextBox txtCustoKM;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgFrota;
        private System.Windows.Forms.ComboBox cmbTabela;
        private System.Windows.Forms.PictureBox imgVeiculo;
        private System.Windows.Forms.TextBox txtVeiculo;
    }
}

