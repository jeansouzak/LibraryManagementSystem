namespace Biblioteca.Editora.View
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telefoneLb = new System.Windows.Forms.Label();
            this.telefoneTb = new System.Windows.Forms.TextBox();
            this.cnpjTb = new System.Windows.Forms.MaskedTextBox();
            this.cnpjLb = new System.Windows.Forms.Label();
            this.nomeLb = new System.Windows.Forms.Label();
            this.nomeTb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numeroTb = new System.Windows.Forms.TextBox();
            this.cepTb = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefoneLb);
            this.groupBox1.Controls.Add(this.telefoneTb);
            this.groupBox1.Controls.Add(this.cnpjTb);
            this.groupBox1.Controls.Add(this.cnpjLb);
            this.groupBox1.Controls.Add(this.nomeLb);
            this.groupBox1.Controls.Add(this.nomeTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editora";
            // 
            // telefoneLb
            // 
            this.telefoneLb.AutoSize = true;
            this.telefoneLb.Location = new System.Drawing.Point(18, 68);
            this.telefoneLb.Name = "telefoneLb";
            this.telefoneLb.Size = new System.Drawing.Size(52, 13);
            this.telefoneLb.TabIndex = 6;
            this.telefoneLb.Text = "Telefone:";
            // 
            // telefoneTb
            // 
            this.telefoneTb.Location = new System.Drawing.Point(21, 84);
            this.telefoneTb.Name = "telefoneTb";
            this.telefoneTb.Size = new System.Drawing.Size(151, 20);
            this.telefoneTb.TabIndex = 5;
            // 
            // cnpjTb
            // 
            this.cnpjTb.Location = new System.Drawing.Point(178, 36);
            this.cnpjTb.Name = "cnpjTb";
            this.cnpjTb.Size = new System.Drawing.Size(151, 20);
            this.cnpjTb.TabIndex = 4;
            // 
            // cnpjLb
            // 
            this.cnpjLb.AutoSize = true;
            this.cnpjLb.Location = new System.Drawing.Point(174, 21);
            this.cnpjLb.Name = "cnpjLb";
            this.cnpjLb.Size = new System.Drawing.Size(44, 13);
            this.cnpjLb.TabIndex = 3;
            this.cnpjLb.Text = "CNPJ: *";
            // 
            // nomeLb
            // 
            this.nomeLb.AutoSize = true;
            this.nomeLb.Location = new System.Drawing.Point(18, 20);
            this.nomeLb.Name = "nomeLb";
            this.nomeLb.Size = new System.Drawing.Size(45, 13);
            this.nomeLb.TabIndex = 1;
            this.nomeLb.Text = "Nome: *";
            // 
            // nomeTb
            // 
            this.nomeTb.Location = new System.Drawing.Point(21, 36);
            this.nomeTb.Name = "nomeTb";
            this.nomeTb.Size = new System.Drawing.Size(151, 20);
            this.nomeTb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numeroTb);
            this.groupBox2.Controls.Add(this.cepTb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // numeroTb
            // 
            this.numeroTb.Location = new System.Drawing.Point(197, 47);
            this.numeroTb.Name = "numeroTb";
            this.numeroTb.Size = new System.Drawing.Size(130, 20);
            this.numeroTb.TabIndex = 9;
            // 
            // cepTb
            // 
            this.cepTb.Location = new System.Drawing.Point(18, 47);
            this.cepTb.Name = "cepTb";
            this.cepTb.Size = new System.Drawing.Size(154, 20);
            this.cepTb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CEP:";
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(280, 242);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 2;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 273);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formulario";
            this.Text = "Formulario Editora";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nomeLb;
        private System.Windows.Forms.TextBox nomeTb;
        private System.Windows.Forms.Label telefoneLb;
        private System.Windows.Forms.TextBox telefoneTb;
        private System.Windows.Forms.MaskedTextBox cnpjTb;
        private System.Windows.Forms.Label cnpjLb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox numeroTb;
        private System.Windows.Forms.MaskedTextBox cepTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salvarBtn;
    }
}