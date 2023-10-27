namespace ProjetoCalculos
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CalculadoraBasica = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CalculadoraRB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CalculadoraOO = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTrocarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculadoraBasica,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.CalculadoraRB,
            this.toolStripSeparator3,
            this.CalculadoraOO,
            this.toolStripSeparator6,
            this.btnTrocarUsuario,
            this.toolStripSeparator5,
            this.btnFechar,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(0, 40);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(622, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CalculadoraBasica
            // 
            this.CalculadoraBasica.AutoSize = false;
            this.CalculadoraBasica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculadoraBasica.Image = ((System.Drawing.Image)(resources.GetObject("CalculadoraBasica.Image")));
            this.CalculadoraBasica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculadoraBasica.Name = "CalculadoraBasica";
            this.CalculadoraBasica.Size = new System.Drawing.Size(50, 40);
            this.CalculadoraBasica.Text = "toolStripSplitButton1";
            this.CalculadoraBasica.ToolTipText = "Calculadora Básica";
            this.CalculadoraBasica.Click += new System.EventHandler(this.CalculadoraBasica_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(50, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Calculadora ++";
            this.toolStripButton1.Click += new System.EventHandler(this.Calculadora);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // CalculadoraRB
            // 
            this.CalculadoraRB.AutoSize = false;
            this.CalculadoraRB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculadoraRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculadoraRB.Image = ((System.Drawing.Image)(resources.GetObject("CalculadoraRB.Image")));
            this.CalculadoraRB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculadoraRB.Name = "CalculadoraRB";
            this.CalculadoraRB.Size = new System.Drawing.Size(50, 40);
            this.CalculadoraRB.Text = "toolStripButton2";
            this.CalculadoraRB.ToolTipText = "Calculadora Radio Buttons";
            this.CalculadoraRB.Click += new System.EventHandler(this.CalculadoraRB_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // CalculadoraOO
            // 
            this.CalculadoraOO.AutoSize = false;
            this.CalculadoraOO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculadoraOO.Image = ((System.Drawing.Image)(resources.GetObject("CalculadoraOO.Image")));
            this.CalculadoraOO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculadoraOO.Name = "CalculadoraOO";
            this.CalculadoraOO.Size = new System.Drawing.Size(50, 40);
            this.CalculadoraOO.Text = "toolStripButton2";
            this.CalculadoraOO.ToolTipText = "Calculadora ComboBox";
            this.CalculadoraOO.Click += new System.EventHandler(this.CalculadoraOO_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = false;
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFechar.Image = global::ProjetoCalculos.Properties.Resources._1330162;
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 40);
            this.btnFechar.Text = "toolStripButton4";
            this.btnFechar.ToolTipText = "Exit";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.UsuarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(622, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Hack", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.LinkColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabel2.Text = "Usuario Logado: ";
            // 
            // UsuarioLogado
            // 
            this.UsuarioLogado.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioLogado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLogado.Name = "UsuarioLogado";
            this.UsuarioLogado.Size = new System.Drawing.Size(0, 17);
            // 
            // btnTrocarUsuario
            // 
            this.btnTrocarUsuario.AutoSize = false;
            this.btnTrocarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTrocarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocarUsuario.Image")));
            this.btnTrocarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrocarUsuario.Name = "btnTrocarUsuario";
            this.btnTrocarUsuario.Size = new System.Drawing.Size(50, 40);
            this.btnTrocarUsuario.Text = "toolStripButton2";
            this.btnTrocarUsuario.ToolTipText = "Trocar de usuário";
            this.btnTrocarUsuario.Click += new System.EventHandler(this.btnTrocarUsuario_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 40);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(622, 287);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CalculadoraBasica;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton CalculadoraRB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CalculadoraOO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioLogado;
        private System.Windows.Forms.ToolStripButton btnTrocarUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}