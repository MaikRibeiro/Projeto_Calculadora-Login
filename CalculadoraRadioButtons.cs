using System;
using System.Windows.Forms;


namespace ProjetoCalculos
{
    public partial class CalculadoraRadioButtons : Form
    {
        public decimal num1{ get; set; }
        public decimal num2{ get; set; }
        public decimal resultado;
        private const int maxComprimento = 10;

        public CalculadoraRadioButtons()
        {
            InitializeComponent();
        }

        private void Somar_CheckedChanged(object sender, EventArgs e)
        {
            if (somar.Checked)
            {
                num1 = decimal.Parse(txtPrimeiroNumero.Text);
                num2 = decimal.Parse(txtSegundoNumero.Text);

                lblSinal.Text = "+";
                lblResultado.Text = Convert.ToString(num1 + num2);
            }
        }

        private void Subtrair_CheckedChanged(object sender, EventArgs e)
        {
            if (subtrair.Checked)
            {
                num1 = decimal.Parse(txtPrimeiroNumero.Text);
                num2 = decimal.Parse(txtSegundoNumero.Text);

                lblSinal.Text = "-";
                lblResultado.Text = Convert.ToString(num1 - num2);
            }
        }

        private void Dividir_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (dividir.Checked)
                {
                    num1 = decimal.Parse(txtPrimeiroNumero.Text);
                    num2 = decimal.Parse(txtSegundoNumero.Text);
                    decimal resultado;

                    lblSinal.Text = "/";
                    resultado = num1 / num2;
                    lblResultado.Text = resultado.ToString("N10");
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is DivideByZeroException)
                {
                    MessageBox.Show("Digite apenas números e que sejam diferentes de zero.");
                }
            }
        }

        private void Multiplicar_CheckedChanged(object sender, EventArgs e)
        {
            if (multiplicar.Checked)
            {
                num1 = decimal.Parse(txtPrimeiroNumero.Text);
                num2 = decimal.Parse(txtSegundoNumero.Text);

                lblSinal.Text = "X";
                lblResultado.Text = Convert.ToString(num1 * num2);
            }
        }

            private void Potencia_CheckedChanged(object sender, EventArgs e)
            {
                try
                {
                    if (potencia.Checked)
                    {
                        double num1 = double.Parse(txtPrimeiroNumero.Text);
                        double num2 = double.Parse(txtSegundoNumero.Text);

                        double answer = Math.Pow(num1, num2);
                        lblResultado.Text = answer.ToString("N1");

                        lblSinal.Text = "^";
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Apenas números");
                }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
            TelaInicial.limiteDeTelasIniciadas = false;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroNumero.Clear();
            txtSegundoNumero.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "";
            txtPrimeiroNumero.Focus();
        }
        
        private void txtPrimeiroNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (txtPrimeiroNumero.Text.Length >= maxComprimento 
                || !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true; 
                }
        }

        private void txtSegundoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSegundoNumero.Text.Length >= maxComprimento || !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        private void txtPrimeiroNumero_TextChanged(object sender, EventArgs e)
        {
            txtPrimeiroNumero.MaxLength = 7;
        }

        private void txtSegundoNumero_TextChanged(object sender, EventArgs e)
        {
            txtSegundoNumero.MaxLength = 7;
        }
    }
}
