namespace Biblioteca.Livro.View
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
            this.enviarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autorCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.duvida = new System.Windows.Forms.Label();
            this.editoraCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantidadeNm = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.categoriaCb = new System.Windows.Forms.ComboBox();
            this.autorLb = new System.Windows.Forms.Label();
            this.edicaoTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnTb = new System.Windows.Forms.TextBox();
            this.nomeTb = new System.Windows.Forms.TextBox();
            this.nomeLb = new System.Windows.Forms.Label();
            this.isbnLb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNm)).BeginInit();
            this.SuspendLayout();
            // 
            // enviarBtn
            // 
            this.enviarBtn.Location = new System.Drawing.Point(280, 287);
            this.enviarBtn.Name = "enviarBtn";
            this.enviarBtn.Size = new System.Drawing.Size(75, 23);
            this.enviarBtn.TabIndex = 9;
            this.enviarBtn.Text = "Enviar";
            this.enviarBtn.UseVisualStyleBackColor = true;
            this.enviarBtn.Click += new System.EventHandler(this.enviarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autorCb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.duvida);
            this.groupBox1.Controls.Add(this.editoraCb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.quantidadeNm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.categoriaCb);
            this.groupBox1.Controls.Add(this.autorLb);
            this.groupBox1.Controls.Add(this.edicaoTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.isbnTb);
            this.groupBox1.Controls.Add(this.nomeTb);
            this.groupBox1.Controls.Add(this.nomeLb);
            this.groupBox1.Controls.Add(this.isbnLb);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 271);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livro";
            // 
            // autorCb
            // 
            this.autorCb.FormattingEnabled = true;
            this.autorCb.Location = new System.Drawing.Point(25, 169);
            this.autorCb.Name = "autorCb";
            this.autorCb.Size = new System.Drawing.Size(153, 21);
            this.autorCb.TabIndex = 21;
            this.autorCb.TextChanged += new System.EventHandler(this.autorCb_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Help;
            this.label9.Location = new System.Drawing.Point(199, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "?";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Help;
            this.label8.Location = new System.Drawing.Point(250, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "?";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // duvida
            // 
            this.duvida.AutoSize = true;
            this.duvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.duvida.Location = new System.Drawing.Point(60, 153);
            this.duvida.Name = "duvida";
            this.duvida.Size = new System.Drawing.Size(13, 13);
            this.duvida.TabIndex = 18;
            this.duvida.Text = "?";
            this.duvida.Click += new System.EventHandler(this.label1_Click);
            // 
            // editoraCb
            // 
            this.editoraCb.FormattingEnabled = true;
            this.editoraCb.Location = new System.Drawing.Point(162, 230);
            this.editoraCb.Name = "editoraCb";
            this.editoraCb.Size = new System.Drawing.Size(175, 21);
            this.editoraCb.TabIndex = 17;
            this.editoraCb.TextChanged += new System.EventHandler(this.editoraCb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Editora:";
            // 
            // quantidadeNm
            // 
            this.quantidadeNm.Location = new System.Drawing.Point(21, 230);
            this.quantidadeNm.Name = "quantidadeNm";
            this.quantidadeNm.Size = new System.Drawing.Size(117, 20);
            this.quantidadeNm.TabIndex = 14;
            this.quantidadeNm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantidadeNm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoria:";
            // 
            // categoriaCb
            // 
            this.categoriaCb.FormattingEnabled = true;
            this.categoriaCb.Location = new System.Drawing.Point(202, 169);
            this.categoriaCb.Name = "categoriaCb";
            this.categoriaCb.Size = new System.Drawing.Size(130, 21);
            this.categoriaCb.TabIndex = 12;
            this.categoriaCb.TextChanged += new System.EventHandler(this.categoriaCb_TextChanged);
            // 
            // autorLb
            // 
            this.autorLb.AutoSize = true;
            this.autorLb.Location = new System.Drawing.Point(22, 153);
            this.autorLb.Name = "autorLb";
            this.autorLb.Size = new System.Drawing.Size(42, 13);
            this.autorLb.TabIndex = 11;
            this.autorLb.Text = "Autor: *";
            // 
            // edicaoTb
            // 
            this.edicaoTb.Location = new System.Drawing.Point(21, 109);
            this.edicaoTb.Name = "edicaoTb";
            this.edicaoTb.Size = new System.Drawing.Size(157, 20);
            this.edicaoTb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade:";
            // 
            // isbnTb
            // 
            this.isbnTb.Location = new System.Drawing.Point(202, 109);
            this.isbnTb.Name = "isbnTb";
            this.isbnTb.Size = new System.Drawing.Size(130, 20);
            this.isbnTb.TabIndex = 5;
            // 
            // nomeTb
            // 
            this.nomeTb.Location = new System.Drawing.Point(21, 47);
            this.nomeTb.Name = "nomeTb";
            this.nomeTb.Size = new System.Drawing.Size(311, 20);
            this.nomeTb.TabIndex = 4;
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
            // isbnLb
            // 
            this.isbnLb.AutoSize = true;
            this.isbnLb.Location = new System.Drawing.Point(199, 93);
            this.isbnLb.Name = "isbnLb";
            this.isbnLb.Size = new System.Drawing.Size(42, 13);
            this.isbnLb.TabIndex = 3;
            this.isbnLb.Text = "ISBN: *";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 314);
            this.Controls.Add(this.enviarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livro";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox editoraCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown quantidadeNm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoriaCb;
        private System.Windows.Forms.Label autorLb;
        private System.Windows.Forms.TextBox edicaoTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnTb;
        private System.Windows.Forms.TextBox nomeTb;
        private System.Windows.Forms.Label nomeLb;
        private System.Windows.Forms.Label isbnLb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label duvida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox autorCb;
    }
}