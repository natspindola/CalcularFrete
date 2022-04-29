using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularFrete
{
    public partial class Calcular_Frete : Form
    {
        float KMRodada = 0;
        float KmAutonomia = 0;
        float QtdCombustivel = 0;
        double custoCombustivel;

        public Calcular_Frete()
        {
            InitializeComponent();
        }

        private void txtVeiculo_TextChanged(object sender, EventArgs e)
        {
            if (txtVeiculo.Text.ToLower() == "carro")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.carro;

            }
            else if (txtVeiculo.Text.ToLower() == "moto")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.moto;
            }
            else if (txtVeiculo.Text.ToLower() == "caminhão")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.caminhao;
            }
            else if (txtVeiculo.Text.ToLower() == "caminhao")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.caminhao;
            }
            else if (txtVeiculo.Text.ToLower() == "van")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.van;
            }
            else
            {
                
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            KMRodada = float.Parse(txtDistancia.Text);

            float KmDobrado = 0;
            if (checkIda.Checked == true)
            {
                KmDobrado = KMRodada * 1;
            }
            else if (checkIdaVolta.Checked == true)
            {
                KmDobrado = KMRodada * 2;
            }

            // consumo do combustível

            QtdCombustivel = KmDobrado / float.Parse(txtAutonomia.Text);

            // custo do combustível

            custoCombustivel = double.Parse(txtValor.Text) * QtdCombustivel;
            txtDespesa.Text = custoCombustivel.ToString();

            txtTotal.Text = Convert.ToString(custoCombustivel * int.Parse(txtTabela.Text));

            txtKMRodado.Text = KmDobrado.ToString();
            txtCustoKM.Text = Convert.ToString(float.Parse(txtTotal.Text) / KmDobrado);
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAutonomia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);

            txtVeiculo.Clear();
            txtLocal.Clear();
            txtValor.Clear();
            txtAutonomia.Clear();
            txtDistancia.Clear();
            txtTabela.SelectedIndex = -1;
            txtTabela.SelectedValue = "";
            txtTabela.Text = "";
            checkIda.Checked = false;
            checkIdaVolta.Checked = false;
        } 

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
    }
}
