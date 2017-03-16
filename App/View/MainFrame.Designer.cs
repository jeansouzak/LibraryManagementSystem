namespace Biblioteca
{
    partial class mainFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastramentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.livroTb = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataHoraLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.usuarioLogadoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataHoraTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.gerenciamentoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.emprestimosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.editorasToolStripMenuItem});
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemToolStripMenuItem,
            this.cadastramentoToolStripMenuItem});
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.listagemToolStripMenuItem.Text = "Listar";
            this.listagemToolStripMenuItem.Click += new System.EventHandler(this.listagemToolStripMenuItem_Click);
            // 
            // cadastramentoToolStripMenuItem
            // 
            this.cadastramentoToolStripMenuItem.Name = "cadastramentoToolStripMenuItem";
            this.cadastramentoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cadastramentoToolStripMenuItem.Text = "Novo";
            this.cadastramentoToolStripMenuItem.Click += new System.EventHandler(this.cadastramentoToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cadastrarToolStripMenuItem.Text = "Novo";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // emprestimosToolStripMenuItem
            // 
            this.emprestimosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.devolverToolStripMenuItem});
            this.emprestimosToolStripMenuItem.Name = "emprestimosToolStripMenuItem";
            this.emprestimosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.emprestimosToolStripMenuItem.Text = "Emprestimos";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.novoToolStripMenuItem.Text = "Emprestar";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.devolverToolStripMenuItem.Text = "Devolver";
            this.devolverToolStripMenuItem.Click += new System.EventHandler(this.devolverToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem2,
            this.novoToolStripMenuItem1});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.listarToolStripMenuItem2.Text = "Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem1.Text = "Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem3,
            this.novoToolStripMenuItem2});
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editorasToolStripMenuItem.Text = "Editoras";
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(103, 22);
            this.listarToolStripMenuItem3.Text = "Listar";
            this.listarToolStripMenuItem3.Click += new System.EventHandler(this.listarToolStripMenuItem3_Click);
            // 
            // novoToolStripMenuItem2
            // 
            this.novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            this.novoToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem2.Text = "Novo";
            this.novoToolStripMenuItem2.Click += new System.EventHandler(this.novoToolStripMenuItem2_Click_1);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.livroTb);
            this.panel2.Controls.Add(this.buscarBtn);
            this.panel2.Location = new System.Drawing.Point(149, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 111);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Livro:";
            // 
            // livroTb
            // 
            this.livroTb.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livroTb.Location = new System.Drawing.Point(14, 47);
            this.livroTb.Multiline = true;
            this.livroTb.Name = "livroTb";
            this.livroTb.Size = new System.Drawing.Size(265, 31);
            this.livroTb.TabIndex = 1;
            this.livroTb.TextChanged += new System.EventHandler(this.livroTb_TextChanged);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(285, 47);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 31);
            this.buscarBtn.TabIndex = 2;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataHoraLabel,
            this.usuarioLogadoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(650, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataHoraLabel
            // 
            this.dataHoraLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dataHoraLabel.Name = "dataHoraLabel";
            this.dataHoraLabel.Size = new System.Drawing.Size(56, 17);
            this.dataHoraLabel.Text = "dataHora";
            // 
            // usuarioLogadoLabel
            // 
            this.usuarioLogadoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.usuarioLogadoLabel.Name = "usuarioLogadoLabel";
            this.usuarioLogadoLabel.Size = new System.Drawing.Size(86, 17);
            this.usuarioLogadoLabel.Text = "usuarioLogado";
            // 
            // dataHoraTimer
            // 
            this.dataHoraTimer.Interval = 1000;
            this.dataHoraTimer.Tick += new System.EventHandler(this.dataHoraTimer_Tick);
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Biblioteca.Properties.Resources.slideshow_bg;
            this.ClientSize = new System.Drawing.Size(650, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Biblioteca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainFrame_FormClosed);
            this.Load += new System.EventHandler(this.mainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastramentoToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox livroTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel dataHoraLabel;
        private System.Windows.Forms.Timer dataHoraTimer;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel usuarioLogadoLabel;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem2;


    }
}

