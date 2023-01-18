using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double numeroPrimeiro;
        string operacao;
        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 9);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Comandos.Numeros(txtcalculo, 0);
        }
        private void BtnSoma_Click(object sender, EventArgs e)
        {
            Comandos.Operacao(txtcalculo, LblOperacao, "+");
            TxtNumero.Text = $"{Memoria.memoria}";
            operacao = "+";
        }
        private void BtnSub_Click(object sender, EventArgs e)
        {
            Comandos.Operacao(txtcalculo, LblOperacao, "-");
            TxtNumero.Text = $"{Memoria.memoria}";
            operacao = "-";
        }
        private void BtnMult_Click(object sender, EventArgs e)
        {
            Comandos.Operacao(txtcalculo, LblOperacao, "x");
            TxtNumero.Text = $"{Memoria.memoria}";
            operacao = "x";
        }
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Comandos.Operacao(txtcalculo, LblOperacao, "/");
            TxtNumero.Text = $"{Memoria.memoria}";
            operacao = "/";
        }
        private void Btnigual_Click(object sender, EventArgs e)
        {
            Calcular calculo = new Calcular();
            if(operacao == "+")
            {
                calculo.Soma(txtcalculo);
                TxtNumero.Text = "";
            }
            else if(operacao == "-")
            {
                calculo.Sub(txtcalculo);
                TxtNumero.Text = "";
            }
            else if(operacao == "x")
            {
                calculo.Mult(txtcalculo);
                TxtNumero.Text = "";
            }
            else if(operacao == "/")
            {
                calculo.Div(txtcalculo);
                TxtNumero.Text = "";
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtcalculo.Text = "0";
            LblOperacao.Text = "";
            Memoria.memoria = 0;
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            if (txtcalculo.Text == "0")
            {
                txtcalculo.Text += ".";
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = txtcalculo.Text;

                Apagar = Apagar.Remove(Apagar.Length - 1);
                txtcalculo.Text = Apagar;
                TxtNumero.Text = Apagar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}