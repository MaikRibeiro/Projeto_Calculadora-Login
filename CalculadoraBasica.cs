using System;
using System.Windows.Forms;
using ProjetoCalculos;

namespace ProjetosCalculos
{
    public partial class CalculadoraBasica : Form
    {
        public CalculadoraBasica()
        {
            InitializeComponent();
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "";
            txtN1.Focus();
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                lblSinal.Text = "+";

                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números");
            }
        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                lblSinal.Text = "-";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Apenas números");
            }

        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                lblSinal.Text = "x";

                a = Convert.ToDouble(txtN1.Text);
                b = Convert.ToDouble(txtN2.Text);

                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Apenas números");
            }
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                lblSinal.Text = "/";

                a = Convert.ToDouble(txtN1.Text);
                b = Convert.ToDouble(txtN2.Text);

                lblResultado.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is DivideByZeroException)
                {
                    MessageBox.Show("Digite apenas números e que sejam diferentes de zero.");
                }
            }
        }        
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
            TelaInicial.limiteDeTelasIniciadas = false;
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {
            txtN1.MaxLength = 5;
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {
            txtN2.MaxLength = 5;
        }
    }
    
}
