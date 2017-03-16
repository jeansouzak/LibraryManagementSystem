namespace Biblioteca.Emprestimo.View
{
    partial class EmprestimoForm
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
            this.devolucaoLb = new System.Windows.Forms.Label();
            this.dataDevolucaoTb = new System.Windows.Forms.MaskedTextBox();
            this.alunoLb = new System.Windows.Forms.Label();
            this.alunoCb = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.livroCb = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.devolucaoLb);
            this.groupBox1.Controls.Add(this.dataDevolucaoTb);
            this.groupBox1.Controls.Add(this.alunoLb);
            this.groupBox1.Controls.Add(this.alunoCb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emprestimo";
            // 
            // devolucaoLb
            // 
            this.devolucaoLb.AutoSize = true;
            this.devolucaoLb.Location = new System.Drawing.Point(210, 22);
            this.devolucaoLb.Name = "devolucaoLb";
            this.devolucaoLb.Size = new System.Drawing.Size(95, 13);
            this.devolucaoLb.TabIndex = 5;
            this.devolucaoLb.Text = "Data Devolução: *";
            // 
            // dataDevolucaoTb
            // 
            this.dataDevolucaoTb.Location = new System.Drawing.Point(213, 39);
            this.dataDevolucaoTb.Mask = "99/99/9999";
            this.dataDevolucaoTb.Name = "dataDevolucaoTb";
            this.dataDevolucaoTb.Size = new System.Drawing.Size(130, 20);
            this.dataDevolucaoTb.TabIndex = 3;
            // 
            // alunoLb
            // 
            this.alunoLb.AutoSize = true;
            this.alunoLb.Location = new System.Drawing.Point(20, 22);
            this.alunoLb.Name = "alunoLb";
            this.alunoLb.Size = new System.Drawing.Size(75, 13);
            this.alunoLb.TabIndex = 1;
            this.alunoLb.Text = "Nome Aluno: *";
            // 
            // alunoCb
            // 
            this.alunoCb.FormattingEnabled = true;
            this.alunoCb.Location = new System.Drawing.Point(23, 38);
            this.alunoCb.Name = "alunoCb";
            this.alunoCb.Size = new System.Drawing.Size(179, 21);
            this.alunoCb.TabIndex = 0;
            this.alunoCb.TextChanged += new System.EventHandler(this.alunoCb_TextChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.autorColumn});
            this.dataGrid.Location = new System.Drawing.Point(12, 210);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(368, 150);
            this.dataGrid.TabIndex = 1;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // nomeColumn
            // 
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // autorColumn
            // 
            this.autorColumn.HeaderText = "Autor";
            this.autorColumn.Name = "autorColumn";
            this.autorColumn.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.livroCb);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.limparBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens:";
            // 
            // livroCb
            // 
            this.livroCb.FormattingEnabled = true;
            this.livroCb.Location = new System.Drawing.Point(23, 36);
            this.livroCb.Name = "livroCb";
            this.livroCb.Size = new System.Drawing.Size(320, 21);
            this.livroCb.TabIndex = 5;
            this.livroCb.TextChanged += new System.EventHandler(this.livroCb_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Enabled = false;
            this.addBtn.Location = new System.Drawing.Point(187, 62);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Location = new System.Drawing.Point(268, 62);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 23);
            this.limparBtn.TabIndex = 3;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Livro:";
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(305, 366);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 4;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // EmprestimoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 389);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmprestimoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Emprestimo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label devolucaoLb;
        private System.Windows.Forms.MaskedTextBox dataDevolucaoTb;
        private System.Windows.Forms.Label alunoLb;
        private System.Windows.Forms.ComboBox alunoCb;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox livroCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorColumn;
    }
}