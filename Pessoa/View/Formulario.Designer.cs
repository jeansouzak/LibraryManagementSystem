namespace Biblioteca.Pessoa.View
{
    partial class Formulario
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
            this.nomeLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoLb = new System.Windows.Forms.Label();
            this.cpfLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpfTb = new System.Windows.Forms.MaskedTextBox();
            this.nomeTb = new System.Windows.Forms.TextBox();
            this.tipoCb = new System.Windows.Forms.ComboBox();
            this.dataNascimentoTb = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numeroTb = new System.Windows.Forms.TextBox();
            this.cepTb = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoGb = new System.Windows.Forms.GroupBox();
            this.senhaTb = new System.Windows.Forms.TextBox();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.senhaLb = new System.Windows.Forms.Label();
            this.loginLb = new System.Windows.Forms.Label();
            this.siteTb = new System.Windows.Forms.MaskedTextBox();
            this.matriculaTb = new System.Windows.Forms.TextBox();
            this.siteLb = new System.Windows.Forms.Label();
            this.matriculaLb = new System.Windows.Forms.Label();
            this.enviarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tipoGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLb
            // 
            this.nomeLb.AutoSize = true;
            this.nomeLb.Location = new System.Drawing.Point(18, 31);
            this.nomeLb.Name = "nomeLb";
            this.nomeLb.Size = new System.Drawing.Size(45, 13);
            this.nomeLb.TabIndex = 0;
            this.nomeLb.Text = "Nome: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento:";
            // 
            // tipoLb
            // 
            this.tipoLb.AutoSize = true;
            this.tipoLb.Location = new System.Drawing.Point(199, 87);
            this.tipoLb.Name = "tipoLb";
            this.tipoLb.Size = new System.Drawing.Size(38, 13);
            this.tipoLb.TabIndex = 2;
            this.tipoLb.Text = "Tipo: *";
            // 
            // cpfLb
            // 
            this.cpfLb.AutoSize = true;
            this.cpfLb.Location = new System.Drawing.Point(200, 31);
            this.cpfLb.Name = "cpfLb";
            this.cpfLb.Size = new System.Drawing.Size(37, 13);
            this.cpfLb.TabIndex = 3;
            this.cpfLb.Text = "CPF: *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpfTb);
            this.groupBox1.Controls.Add(this.nomeTb);
            this.groupBox1.Controls.Add(this.tipoCb);
            this.groupBox1.Controls.Add(this.dataNascimentoTb);
            this.groupBox1.Controls.Add(this.nomeLb);
            this.groupBox1.Controls.Add(this.tipoLb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cpfLb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pessoa";
            // 
            // cpfTb
            // 
            this.cpfTb.Location = new System.Drawing.Point(202, 46);
            this.cpfTb.Mask = "999-999-999-99";
            this.cpfTb.Name = "cpfTb";
            this.cpfTb.Size = new System.Drawing.Size(130, 20);
            this.cpfTb.TabIndex = 1;
            // 
            // nomeTb
            // 
            this.nomeTb.Location = new System.Drawing.Point(21, 47);
            this.nomeTb.Name = "nomeTb";
            this.nomeTb.Size = new System.Drawing.Size(157, 20);
            this.nomeTb.TabIndex = 0;
            // 
            // tipoCb
            // 
            this.tipoCb.FormattingEnabled = true;
            this.tipoCb.Items.AddRange(new object[] {
            "Aluno",
            "Usuário",
            "Autor"});
            this.tipoCb.Location = new System.Drawing.Point(202, 103);
            this.tipoCb.Name = "tipoCb";
            this.tipoCb.Size = new System.Drawing.Size(130, 21);
            this.tipoCb.TabIndex = 3;
            this.tipoCb.SelectedIndexChanged += new System.EventHandler(this.tipoCb_SelectedIndexChanged);
            // 
            // dataNascimentoTb
            // 
            this.dataNascimentoTb.Location = new System.Drawing.Point(21, 103);
            this.dataNascimentoTb.Mask = "00/00/0000";
            this.dataNascimentoTb.Name = "dataNascimentoTb";
            this.dataNascimentoTb.Size = new System.Drawing.Size(157, 20);
            this.dataNascimentoTb.TabIndex = 2;
            this.dataNascimentoTb.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numeroTb);
            this.groupBox2.Controls.Add(this.cepTb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // numeroTb
            // 
            this.numeroTb.Location = new System.Drawing.Point(202, 37);
            this.numeroTb.Name = "numeroTb";
            this.numeroTb.Size = new System.Drawing.Size(130, 20);
            this.numeroTb.TabIndex = 5;
            this.numeroTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTb_KeyPress);
            // 
            // cepTb
            // 
            this.cepTb.Location = new System.Drawing.Point(23, 37);
            this.cepTb.Name = "cepTb";
            this.cepTb.Size = new System.Drawing.Size(154, 20);
            this.cepTb.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP:";
            // 
            // tipoGb
            // 
            this.tipoGb.Controls.Add(this.senhaTb);
            this.tipoGb.Controls.Add(this.loginTb);
            this.tipoGb.Controls.Add(this.senhaLb);
            this.tipoGb.Controls.Add(this.loginLb);
            this.tipoGb.Controls.Add(this.siteTb);
            this.tipoGb.Controls.Add(this.matriculaTb);
            this.tipoGb.Controls.Add(this.siteLb);
            this.tipoGb.Controls.Add(this.matriculaLb);
            this.tipoGb.Location = new System.Drawing.Point(13, 256);
            this.tipoGb.Name = "tipoGb";
            this.tipoGb.Size = new System.Drawing.Size(342, 125);
            this.tipoGb.TabIndex = 6;
            this.tipoGb.TabStop = false;
            // 
            // senhaTb
            // 
            this.senhaTb.Enabled = false;
            this.senhaTb.Location = new System.Drawing.Point(202, 86);
            this.senhaTb.Name = "senhaTb";
            this.senhaTb.Size = new System.Drawing.Size(129, 20);
            this.senhaTb.TabIndex = 9;
            this.senhaTb.UseSystemPasswordChar = true;
            // 
            // loginTb
            // 
            this.loginTb.Enabled = false;
            this.loginTb.Location = new System.Drawing.Point(23, 87);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(151, 20);
            this.loginTb.TabIndex = 8;
            // 
            // senhaLb
            // 
            this.senhaLb.AutoSize = true;
            this.senhaLb.Location = new System.Drawing.Point(198, 71);
            this.senhaLb.Name = "senhaLb";
            this.senhaLb.Size = new System.Drawing.Size(41, 13);
            this.senhaLb.TabIndex = 5;
            this.senhaLb.Text = "Senha:";
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(23, 71);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(36, 13);
            this.loginLb.TabIndex = 4;
            this.loginLb.Text = "Login:";
            // 
            // siteTb
            // 
            this.siteTb.Enabled = false;
            this.siteTb.Location = new System.Drawing.Point(201, 36);
            this.siteTb.Name = "siteTb";
            this.siteTb.Size = new System.Drawing.Size(131, 20);
            this.siteTb.TabIndex = 7;
            // 
            // matriculaTb
            // 
            this.matriculaTb.Enabled = false;
            this.matriculaTb.Location = new System.Drawing.Point(23, 36);
            this.matriculaTb.Name = "matriculaTb";
            this.matriculaTb.Size = new System.Drawing.Size(151, 20);
            this.matriculaTb.TabIndex = 6;
            // 
            // siteLb
            // 
            this.siteLb.AutoSize = true;
            this.siteLb.Location = new System.Drawing.Point(198, 20);
            this.siteLb.Name = "siteLb";
            this.siteLb.Size = new System.Drawing.Size(28, 13);
            this.siteLb.TabIndex = 1;
            this.siteLb.Text = "Site:";
            // 
            // matriculaLb
            // 
            this.matriculaLb.AutoSize = true;
            this.matriculaLb.Location = new System.Drawing.Point(23, 20);
            this.matriculaLb.Name = "matriculaLb";
            this.matriculaLb.Size = new System.Drawing.Size(53, 13);
            this.matriculaLb.TabIndex = 0;
            this.matriculaLb.Text = "Matricula:";
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(280, 387);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(75, 23);
            this.enviarBtn.TabIndex = 7;
            this.enviarBtn.Text = "Enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 418);
            this.Controls.Add(this.enviarBtn);
            this.Controls.Add(this.tipoGb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 457);
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoa";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tipoGb.ResumeLayout(false);
            this.tipoGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nomeLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tipoLb;
        private System.Windows.Forms.Label cpfLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox tipoGb;
        private System.Windows.Forms.ComboBox tipoCb;
        private System.Windows.Forms.MaskedTextBox dataNascimentoTb;
        private System.Windows.Forms.MaskedTextBox cepTb;
        private System.Windows.Forms.TextBox senhaTb;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.Label senhaLb;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.MaskedTextBox siteTb;
        private System.Windows.Forms.TextBox matriculaTb;
        private System.Windows.Forms.Label siteLb;
        private System.Windows.Forms.Label matriculaLb;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.MaskedTextBox cpfTb;
        private System.Windows.Forms.TextBox nomeTb;
        private System.Windows.Forms.TextBox numeroTb;
    }
}