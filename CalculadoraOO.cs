using Projeto_CalculadoraOrientada_a_Objetos.Classes;
using System;
using System.Windows.Forms;

namespace ProjetoCalculos
{
    public partial class CalculadoraOO : Form
    {
        public CalculadoraOO()
        {
            InitializeComponent();
        }
        private void CmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal a, b;
            a = decimal.Parse(txtN1.Text);
            b = decimal.Parse(txtN2.Text);
            switch (cmbOperacao.Text)
            {
                case "Somar":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        objCalc.Soma();
                        lblResultado.Text = objCalc.Resultado.ToString();
                        break;
                    }
                case "Subtrair":
                    {
                        //INSTANCIANDO A CLASSE
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Subtrair();
                        break;
                    }
                case "Multiplicar":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Multiplicar().ToString();
                        break;
                    }
                case "Dividir":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        lblResultado.Text = objCalc.Dividir(a, b);
                        break;
                    }
                case "Potenciação":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultado.Text = objCalc.Potenciacao();
                        break;
                    }
                case "Comparar":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        lblResultadoTexto.Text = objCalc.Comparar(a, b);
                        break;
                    }
                case "Par_Impar":
                    {
                        CalcCientifica objCalc = new CalcCientifica();
                        objCalc.Num1 = a;
                        objCalc.Num2 = b;
                        lblResultadoTexto.Text = objCalc.Par_Impar();
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            TelaInicial.limiteDeTelasIniciadas = false;
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {
            txtN1.MaxLength = 9;
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {
            txtN2.MaxLength = 9;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblResultado.Text = "";
            lblResultadoTexto.Text = "";
            cmbOperacao.Text = "";
            txtN1.Focus();
        }
    }
}
