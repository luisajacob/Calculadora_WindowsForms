using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_introWF
{
    public partial class Form1 : Form
    {
        //atributos de operação
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool porcentagem = false;
        bool resultado = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//tecla 1 para as duas textbox
        {
            txtResultado.Text += "1";
            txtOperacao.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)//tecla 2 para as duas textbox
        {
            txtResultado.Text += "2";
            txtOperacao.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)//tecla 3 para as duas textbox
        {
            txtResultado.Text += "3";
            txtOperacao.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)//tecla 4 para as duas textbox
        {
            txtResultado.Text += "4";
            txtOperacao.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)//tecla 5 para as duas textbox
        {
            txtResultado.Text += "5";
            txtOperacao.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)//tecla 6 para as duas textbox
        {
            txtResultado.Text += "6";
            txtOperacao.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)//tecla 7 para as duas textbox
        {
            txtResultado.Text += "7";
            txtOperacao.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)//tecla 8 para as duas textbox
        {
            txtResultado.Text += "8";
            txtOperacao.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)//tecla 9 para as duas textbox
        {
            txtResultado.Text += "9";
            txtOperacao.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)//tecla 0 para as duas textbox
        {
            txtResultado.Text += "0";
            txtOperacao.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)//tecla adição
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "+";

            txtResultado.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
            porcentagem = false;
        }

        private void button12_Click(object sender, EventArgs e)//tecla igualdade
        {
            resultado = true;

            txtOperacao.Text += "=";

            //operação de adição
            if(adicao == true)
            {
                txtResultado.Text = Convert.ToString(calculo + Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text += txtResultado.Text;
            }
            //operação de subtração
            if (subtracao == true)
            {
                txtResultado.Text = Convert.ToString(calculo - Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text += txtResultado.Text;
            }
            //operação de multiplicação
            if (multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(calculo * Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text += txtResultado.Text;
            }
            //operação de divisão
            if (divisao == true)
            {
                txtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text += txtResultado.Text;
            }
            //operação de porcentagem
            if (porcentagem == true)
            {
                txtResultado.Text = Convert.ToString(calculo * (Convert.ToDecimal(txtResultado.Text)/100));

                txtOperacao.Text += txtResultado.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)//tecla C - limpar tudo
        {
            txtResultado.Text = "";
            txtOperacao.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)//tecla subtração
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "-";

            txtResultado.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
            porcentagem = false;
        }

        private void button18_Click(object sender, EventArgs e)//tecla multiplicação
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "x";

            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
            porcentagem = false;
        }

        private void button19_Click(object sender, EventArgs e)//tecla divisão
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "/";

            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
            porcentagem = false;
        }

        private void button11_Click(object sender, EventArgs e)//tecla vírgula
        {
            txtResultado.Text += ",";
            txtOperacao.Text += ",";
        }

        private void button14_Click(object sender, EventArgs e)//tecla AC
        {
            try
            {
                string Apagar = txtResultado.Text;

                Apagar = Apagar.Remove(Apagar.Length - 1);

                txtResultado.Text = Apagar;
                txtOperacao.Text = Apagar;
            }
            catch(Exception)
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)//tecla porcentagem
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "%";

            txtResultado.Text = Convert.ToString(calculo/100);

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
            porcentagem = true;
        }
    }
}
