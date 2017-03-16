namespace Biblioteca.Livro.View
{
    partial class LivroFrame
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
            this.label9 = new System.Windows.Forms.Label();
            this.removerBtn = new System.Windows.Forms.Button();
            this.categoriaCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.livroTb = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicaoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.removerBtn);
            this.groupBox1.Controls.Add(this.categoriaCb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.editarBtn);
            this.groupBox1.Controls.Add(this.limparBtn);
            this.groupBox1.Controls.Add(this.cadastrarBtn);
            this.groupBox1.Controls.Add(this.buscarBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.livroTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Help;
            this.label9.Location = new System.Drawing.Point(286, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "?";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // removerBtn
            // 
            this.removerBtn.Enabled = false;
            this.removerBtn.Location = new System.Drawing.Point(349, 49);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(75, 23);
            this.removerBtn.TabIndex = 6;
            this.removerBtn.Text = "Remover";
            this.removerBtn.UseVisualStyleBackColor = true;
            this.removerBtn.Click += new System.EventHandler(this.removerBtn_Click);
            // 
            // categoriaCb
            // 
            this.categoriaCb.FormattingEnabled = true;
            this.categoriaCb.Location = new System.Drawing.Point(304, 22);
            this.categoriaCb.Name = "categoriaCb";
            this.categoriaCb.Size = new System.Drawing.Size(128, 21);
            this.categoriaCb.TabIndex = 5;
            this.categoriaCb.TextChanged += new System.EventHandler(this.categoriaCb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria:";
            // 
            // editarBtn
            // 
            this.editarBtn.Enabled = false;
            this.editarBtn.Location = new System.Drawing.Point(187, 49);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 1;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Location = new System.Drawing.Point(268, 49);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 23);
            this.limparBtn.TabIndex = 3;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.Location = new System.Drawing.Point(106, 49);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBtn.TabIndex = 0;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(25, 49);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 2;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Livro:";
            // 
            // livroTb
            // 
            this.livroTb.Location = new System.Drawing.Point(45, 23);
            this.livroTb.Name = "livroTb";
            this.livroTb.Size = new System.Drawing.Size(183, 20);
            this.livroTb.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.autorColumn,
            this.editoraColumn,
            this.edicaoColumn,
            this.quantidadeColumn});
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(12, 104);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(448, 290);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
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
            // editoraColumn
            // 
            this.editoraColumn.HeaderText = "Editora";
            this.editoraColumn.Name = "editoraColumn";
            this.editoraColumn.ReadOnly = true;
            // 
            // edicaoColumn
            // 
            this.edicaoColumn.HeaderText = "Edição";
            this.edicaoColumn.Name = "edicaoColumn";
            this.edicaoColumn.ReadOnly = true;
            this.edicaoColumn.Width = 70;
            // 
            // quantidadeColumn
            // 
            this.quantidadeColumn.HeaderText = "Quantidade";
            this.quantidadeColumn.Name = "quantidadeColumn";
            this.quantidadeColumn.ReadOnly = true;
            this.quantidadeColumn.Width = 80;
            // 
            // LivroFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 397);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "LivroFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.LivroFrame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox categoriaCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox livroTb;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicaoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeColumn;
        private System.Windows.Forms.Label label9;
    }
}