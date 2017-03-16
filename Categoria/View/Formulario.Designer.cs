namespace Biblioteca.Categoria.View
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
            this.nomeTb = new System.Windows.Forms.TextBox();
            this.nomeLb = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeTb
            // 
            this.nomeTb.Location = new System.Drawing.Point(11, 34);
            this.nomeTb.Name = "nomeTb";
            this.nomeTb.Size = new System.Drawing.Size(240, 20);
            this.nomeTb.TabIndex = 0;
            // 
            // nomeLb
            // 
            this.nomeLb.AutoSize = true;
            this.nomeLb.Location = new System.Drawing.Point(8, 18);
            this.nomeLb.Name = "nomeLb";
            this.nomeLb.Size = new System.Drawing.Size(45, 13);
            this.nomeLb.TabIndex = 1;
            this.nomeLb.Text = "Nome: *";
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(197, 97);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 1;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomeTb);
            this.groupBox1.Controls.Add(this.nomeLb);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(282, 128);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salvarBtn);
            this.Name = "Formulario";
            this.Text = "Formulario Categoria";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nomeLb;
        private System.Windows.Forms.TextBox nomeTb;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}