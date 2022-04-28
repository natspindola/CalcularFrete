﻿using System;
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
            if (txtVeiculo.Text == "carro")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.carro;

            }
            else if (txtVeiculo.Text == "moto")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.moto;
            }
            else if (txtVeiculo.Text == "caminhão")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.caminhao;
            }
            else if (txtVeiculo.Text == "caminhao")
            {
                imgVeiculo.Image = CalcularFrete.Properties.Resources.caminhao;
            }
            else if (txtVeiculo.Text == "van")
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

            QtdCombustivel = KmDobrado / float.Parse(txtConsumo.Text);

            // custo do combustível

            custoCombustivel = double.Parse(txtCombustivel.Text) * QtdCombustivel;
            txtDespesa.Text = custoCombustivel.ToString();
        }
    }
}
