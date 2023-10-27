namespace ProjetoCalculos
{
    partial class CalculadoraRadioButtons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraRadioButtons));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.potencia = new System.Windows.Forms.RadioButton();
            this.multiplicar = new System.Windows.Forms.RadioButton();
            this.dividir = new System.Windows.Forms.RadioButton();
            this.subtrair = new System.Windows.Forms.RadioButton();
            this.somar = new System.Windows.Forms.RadioButton();
            this.lblSinal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.potencia);
            this.groupBox1.Controls.Add(this.multiplicar);
            this.groupBox1.Controls.Add(this.dividir);
            this.groupBox1.Controls.Add(this.subtrair);
            this.groupBox1.Controls.Add(this.somar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações Aritméticas";
            // 
            // potencia
            // 
            this.potencia.AutoSize = true;
            this.potencia.Location = new System.Drawing.Point(6, 108);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(85, 17);
            this.potencia.TabIndex = 7;
            this.potencia.Text = "&Potenciação";
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.CheckedChanged += new System.EventHandler(this.Potencia_CheckedChanged);
            // 
            // multiplicar
            // 
            this.multiplicar.AutoSize = true;
            this.multiplicar.Location = new System.Drawing.Point(6, 85);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(72, 17);
            this.multiplicar.TabIndex = 6;
            this.multiplicar.Text = "&Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.CheckedChanged += new System.EventHandler(this.Multiplicar_CheckedChanged);
            // 
            // dividir
            // 
            this.dividir.AutoSize = true;
            this.dividir.Location = new System.Drawing.Point(6, 62);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(54, 17);
            this.dividir.TabIndex = 5;
            this.dividir.Text = "&Dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.CheckedChanged += new System.EventHandler(this.Dividir_CheckedChanged);
            // 
            // subtrair
            // 
            this.subtrair.AutoSize = true;
            this.subtrair.Location = new System.Drawing.Point(6, 39);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(61, 17);
            this.subtrair.TabIndex = 4;
            this.subtrair.Text = "Sub&trair";
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.CheckedChanged += new System.EventHandler(this.Subtrair_CheckedChanged);
            // 
            // somar
            // 
            this.somar.AutoSize = true;
            this.somar.Location = new System.Drawing.Point(6, 16);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(55, 17);
            this.somar.TabIndex = 3;
            this.somar.Text = "&Somar";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.CheckedChanged += new System.EventHandler(this.Somar_CheckedChanged);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BackColor = System.Drawing.Color.Transparent;
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSinal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSinal.Location = new System.Drawing.Point(273, 57);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(15, 15);
            this.lblSinal.TabIndex = 4;
            this.lblSinal.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(427, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "=";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(213, 106);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 34);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(362, 106);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtPrimeiroNumero
            // 
            this.txtPrimeiroNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeiroNumero.Location = new System.Drawing.Point(155, 54);
            this.txtPrimeiroNumero.MaximumSize = new System.Drawing.Size(100, 22);
            this.txtPrimeiroNumero.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            this.txtPrimeiroNumero.Size = new System.Drawing.Size(90, 22);
            this.txtPrimeiroNumero.TabIndex = 1;
            this.txtPrimeiroNumero.Tag = "";
            this.txtPrimeiroNumero.TextChanged += new System.EventHandler(this.txtPrimeiroNumero_TextChanged);
            this.txtPrimeiroNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimeiroNumero_KeyPress);
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(325, 54);
            this.txtSegundoNumero.MaximumSize = new System.Drawing.Size(100, 22);
            this.txtSegundoNumero.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(90, 20);
            this.txtSegundoNumero.TabIndex = 2;
            this.txtSegundoNumero.TextChanged += new System.EventHandler(this.txtSegundoNumero_TextChanged);
            this.txtSegundoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNumero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "1º Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(322, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "2º Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(479, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(460, 53);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 23);
            this.lblResultado.TabIndex = 15;
            // 
            // CalculadoraRadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 170);
            this.ControlBox = false;
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSegundoNumero);
            this.Controls.Add(this.txtPrimeiroNumero);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CalculadoraRadioButtons";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculadoraRB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton potencia;
        private System.Windows.Forms.RadioButton multiplicar;
        private System.Windows.Forms.RadioButton dividir;
        private System.Windows.Forms.RadioButton subtrair;
        private System.Windows.Forms.RadioButton somar;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtPrimeiroNumero;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
    }
}