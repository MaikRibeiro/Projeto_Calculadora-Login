using System;
using System.Windows.Forms;
using TelaLogin;

namespace ProjetoCalculos
{
    public partial class CalculadoraPlus : Form
    { 
        public bool zeroInicialRemovido = true;

        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public CalculadoraPlus()
        {
            InitializeComponent();
            lblResultado.Text = "0";
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!zeroInicialRemovido)
            {
                if (lblResultado.Text != "0")
                    lblResultado.Text += "0";
            }
            else
            {
                lblResultado.Text = "0";
                zeroInicialRemovido = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "1";
            }
            else
            {
                lblResultado.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "2";
            }
            else
            {
                lblResultado.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "3";
            }
            else
            {
                lblResultado.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "4";
            }
            else
            {
                lblResultado.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "5";
            }
            else
            {
                lblResultado.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "6";
            }
            else
            {
                lblResultado.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "7";
            }
            else
            {
                lblResultado.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "8";
            }
            else
            {
                lblResultado.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "0")
            {
                lblResultado.Text = "9";
            }
            else
            {
                lblResultado.Text += "9";
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = decimal.Parse(lblResultado.Text);
            lblResultado.Text = "";
            lblSinal.Text = "+";
            lblResultado.Focus();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(lblResultado.Text);
            lblResultado.Text = "";
            lblSinal.Text = "-";
            lblResultado.Focus();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Valor = decimal.Parse(lblResultado.Text);
            OperacaoSelecionada = Operacao.Multiplicacao;
            lblResultado.Text = "";
            lblSinal.Text = "x";
            lblResultado.Focus();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(lblResultado.Text);
            lblResultado.Text = "";
            lblSinal.Text = "/";
            lblResultado.Focus();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + decimal.Parse(lblResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - decimal.Parse(lblResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * decimal.Parse(lblResultado.Text);
                    break;
                case Operacao.Divisao:
                    decimal divisor = decimal.Parse(lblResultado.Text);
                    if (divisor != 0)
                        Resultado = Valor / divisor;
                    else
                        lblResultado.Text = "Erro"; // Tratamento de erro
                    break;
            }
            lblResultado.Text = Convert.ToString(Resultado);
            lblSinal.Text = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!lblResultado.Text.Contains(","))
                lblResultado.Text += ",";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            Resultado = 0;
            lblSinal.Text = "";
            lblResultado.Text = "0";

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            Valor = 0;
            lblSinal.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length >0)
            {
                lblResultado.Text = lblResultado.Text.Substring(0, lblResultado.Text.Length - 1);

                if(lblResultado.Text == "")
                {
                    lblResultado.Text = "0";
                }
            }
        }

        private bool keyPressHandled = false;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!keyPressHandled)
            {
                char keyPressed = e.KeyChar;
                if (Char.IsDigit(keyPressed))
                {
                    if (lblResultado.Text == "0")
                    {
                        lblResultado.Text = "";
                        lblResultado.Text += Convert.ToString(keyPressed);
                    }
                    else
                    {
                        lblResultado.Text += Convert.ToString(keyPressed);
                    }


                }
                else
                {
                    switch (keyPressed)
                    {
                        case '+':
                            btnAdicao_Click(sender, e);
                            break;
                        case '-':
                            btnSubtracao_Click(sender, e);
                            break;
                        case '*':
                            btnMultiplicacao_Click(sender, e);
                            break;
                        case '/':
                            btnDivisao_Click(sender, e);
                            break;
                        case (char)Keys.Enter:
                            btnIgual_Click(sender, e);
                            break;
                        case (char)Keys.Back:
                            btnExcluir_Click(sender, e);
                            break;
                        case ',':
                            btnVirgula_Click(sender, e);
                            break;
                    }
                }
                    keyPressHandled = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keyPressHandled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TelaInicial.limiteDeTelasIniciadas = false;
            Close();
            
        }
    }
}
