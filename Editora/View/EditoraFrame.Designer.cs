namespace Biblioteca.Editora.View
{
    partial class EditoraFrame
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removerBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.telefoneColumn,
            this.cnpjColumn,
            this.cepColumn});
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(12, 100);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(450, 290);
            this.dataGrid.TabIndex = 4;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick_1);
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
            this.nomeColumn.Width = 150;
            // 
            // telefoneColumn
            // 
            this.telefoneColumn.HeaderText = "Telefone";
            this.telefoneColumn.Name = "telefoneColumn";
            this.telefoneColumn.ReadOnly = true;
            // 
            // cnpjColumn
            // 
            this.cnpjColumn.HeaderText = "CNPJ";
            this.cnpjColumn.Name = "cnpjColumn";
            this.cnpjColumn.ReadOnly = true;
            // 
            // cepColumn
            // 
            this.cepColumn.HeaderText = "CEP";
            this.cepColumn.Name = "cepColumn";
            this.cepColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removerBtn);
            this.groupBox1.Controls.Add(this.editarBtn);
            this.groupBox1.Controls.Add(this.limparBtn);
            this.groupBox1.Controls.Add(this.cadastrarBtn);
            this.groupBox1.Controls.Add(this.buscarBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nomeTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editora";
            // 
            // removerBtn
            // 
            this.removerBtn.Location = new System.Drawing.Point(345, 49);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(75, 23);
            this.removerBtn.TabIndex = 6;
            this.removerBtn.Text = "Remover";
            this.removerBtn.UseVisualStyleBackColor = true;
            this.removerBtn.Click += new System.EventHandler(this.removerBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(183, 49);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 1;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Location = new System.Drawing.Point(264, 49);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 23);
            this.limparBtn.TabIndex = 3;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.Location = new System.Drawing.Point(102, 49);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBtn.TabIndex = 0;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(21, 49);
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
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome / CNPJ:";
            // 
            // nomeTb
            // 
            this.nomeTb.Location = new System.Drawing.Point(163, 19);
            this.nomeTb.Name = "nomeTb";
            this.nomeTb.Size = new System.Drawing.Size(191, 20);
            this.nomeTb.TabIndex = 0;
            // 
            // EditoraFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 398);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditoraFrame";
            this.Text = "Editoras";
            this.Load += new System.EventHandler(this.EditoraFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepColumn;
    }
}