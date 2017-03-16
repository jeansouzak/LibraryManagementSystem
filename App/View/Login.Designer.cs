namespace Biblioteca.App.View
{
    partial class Login
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
            this.cadastroBtn = new System.Windows.Forms.Button();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.senhaTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cadastroBtn);
            this.groupBox1.Controls.Add(this.entrarBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.senhaTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loginTb);
            this.groupBox1.Location = new System.Drawing.Point(33, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // cadastroBtn
            // 
            this.cadastroBtn.Location = new System.Drawing.Point(98, 108);
            this.cadastroBtn.Name = "cadastroBtn";
            this.cadastroBtn.Size = new System.Drawing.Size(75, 23);
            this.cadastroBtn.TabIndex = 5;
            this.cadastroBtn.Text = "Cadastrar";
            this.cadastroBtn.UseVisualStyleBackColor = true;
            this.cadastroBtn.Click += new System.EventHandler(this.cadastroBtn_Click);
            // 
            // entrarBtn
            // 
            this.entrarBtn.Location = new System.Drawing.Point(179, 108);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(75, 23);
            this.entrarBtn.TabIndex = 4;
            this.entrarBtn.Text = "Entrar";
            this.entrarBtn.UseVisualStyleBackColor = true;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // senhaTb
            // 
            this.senhaTb.Location = new System.Drawing.Point(27, 82);
            this.senhaTb.Name = "senhaTb";
            this.senhaTb.Size = new System.Drawing.Size(227, 20);
            this.senhaTb.TabIndex = 2;
            this.senhaTb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(27, 36);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(227, 20);
            this.loginTb.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 252);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senhaTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.Button cadastroBtn;
    }
}