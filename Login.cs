using System;
using System.Windows.Forms;
using ProjetoCalculos;

namespace TelaLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUsuario.Text.Equals("admin") && txtSenha.Text.Equals("admin"))
                    || (txtUsuario.Text.Equals("user") && txtSenha.Text.Equals("")))
                {
                    TelaInicial home = new TelaInicial();
                    home.Show();

                    home.UpdateStatusLabel(txtUsuario.Text);

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Desculpe",
                         ex.Message,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error) ;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        { 
            txtSenha.MaxLength = 16;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 20;
        }
    }
}
