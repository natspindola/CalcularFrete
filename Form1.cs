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
        public Calcular_Frete()
        {
            InitializeComponent();
        }

        private void txtvVeiculo_TextChanged(object sender, EventArgs e)
        {
            if(txtVeiculo.Text == "carro")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.carro;
                
            }
            else if(txtVeiculo.Text == "moto")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.moto;
            }
            else if(txtVeiculo.Text == "caminhão")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.caminhao;
            }
            else if(txtVeiculo.Text == "van")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.van;
            }
        }
    }
}
