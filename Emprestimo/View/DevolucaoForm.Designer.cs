namespace Biblioteca.Emprestimo.View
{
    partial class DevolucaoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.codigoTb = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.consultarBtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicaoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucaoColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.codigoTb);
            this.groupBox1.Controls.Add(this.buscarBtn);
            this.groupBox1.Controls.Add(this.consultarBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Emprestimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código do emprestimo:";
            // 
            // codigoTb
            // 
            this.codigoTb.Location = new System.Drawing.Point(18, 39);
            this.codigoTb.Name = "codigoTb";
            this.codigoTb.Size = new System.Drawing.Size(195, 20);
            this.codigoTb.TabIndex = 7;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(18, 67);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 5;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // consultarBtn
            // 
            this.consultarBtn.Enabled = false;
            this.consultarBtn.Location = new System.Drawing.Point(110, 67);
            this.consultarBtn.Name = "consultarBtn";
            this.consultarBtn.Size = new System.Drawing.Size(103, 23);
            this.consultarBtn.TabIndex = 4;
            this.consultarBtn.Text = "Consultar Dados";
            this.consultarBtn.UseVisualStyleBackColor = true;
            this.consultarBtn.Click += new System.EventHandler(this.consultarBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeLivroColumn,
            this.autorColumn,
            this.editoraColumn,
            this.edicaoColumn,
            this.devolucaoColumn});
            this.dataGrid.Location = new System.Drawing.Point(12, 121);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(509, 312);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // nomeLivroColumn
            // 
            this.nomeLivroColumn.HeaderText = "Nome";
            this.nomeLivroColumn.Name = "nomeLivroColumn";
            // 
            // autorColumn
            // 
            this.autorColumn.HeaderText = "Autor";
            this.autorColumn.Name = "autorColumn";
            // 
            // editoraColumn
            // 
            this.editoraColumn.HeaderText = "Editora";
            this.editoraColumn.Name = "editoraColumn";
            // 
            // edicaoColumn
            // 
            this.edicaoColumn.HeaderText = "Edição";
            this.edicaoColumn.Name = "edicaoColumn";
            this.edicaoColumn.Width = 80;
            // 
            // devolucaoColumn
            // 
            this.devolucaoColumn.HeaderText = "Devolvido";
            this.devolucaoColumn.Name = "devolucaoColumn";
            this.devolucaoColumn.Width = 80;
            // 
            // DevolucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 441);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "DevolucaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efetuar Devolução";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button consultarBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codigoTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicaoColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn devolucaoColumn;
    }
}