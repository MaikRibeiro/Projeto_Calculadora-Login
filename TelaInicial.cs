using System;
using System.Windows.Forms;
using ProjetosCalculos;
using TelaLogin;

namespace ProjetoCalculos
{
    public partial class TelaInicial : Form
    {
        public static Boolean limiteDeTelasIniciadas = false;
        public TelaInicial()
        {
            InitializeComponent();

        }
        private void Calculadora(object sender, EventArgs e)
        {
            

            if (!limiteDeTelasIniciadas)
            {
                limiteDeTelasIniciadas = true;
                CalculadoraPlus Calculadora = new CalculadoraPlus();
                Calculadora.MdiParent = this;
                Calculadora.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma calculadora em aberto",
                                "Desculpe!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        private void CalculadoraBasica_Click(object sender, EventArgs e)
        {
            
            if (!limiteDeTelasIniciadas)
            {
                limiteDeTelasIniciadas = true;
                CalculadoraBasica calcBasica = new CalculadoraBasica();
                calcBasica.MdiParent = this;
                calcBasica.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma calculadora em aberto",
                                "Desculpe!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        private void CalculadoraRB_Click(object sender, EventArgs e)
        {
            if (!limiteDeTelasIniciadas)
            {
                limiteDeTelasIniciadas = true;
                var calcRB = new CalculadoraRadioButtons();
                calcRB.MdiParent = this;
                calcRB.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma calculadora em aberto",
                                "Desculpe!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void CalculadoraOO_Click(object sender, EventArgs e)
        {
           
            if (!limiteDeTelasIniciadas)
            {
                limiteDeTelasIniciadas = true;
                CalculadoraOO calcOO = new CalculadoraOO();
                calcOO.MdiParent = this;
                calcOO.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma calculadora em aberto",
                                 "Desculpe!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void UpdateStatusLabel(string newText)
        {
            UsuarioLogado.Text = newText;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnTrocarUsuario_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
