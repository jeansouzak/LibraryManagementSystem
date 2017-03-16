namespace Biblioteca.Emprestimo.View
{
    partial class Relatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relatorioEmprestimo = new Biblioteca.RelatorioEmprestimo();
            this.relatorioEmprestimoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioEmprestimoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioEmprestimoTableAdapter = new Biblioteca.RelatorioEmprestimoTableAdapters.RelatorioEmprestimoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioEmprestimoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioEmprestimoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "Emprestimo";
            reportDataSource1.Value = this.relatorioEmprestimoBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.Emprestimo.View.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(722, 297);
            this.reportViewer1.TabIndex = 0;
            // 
            // relatorioEmprestimo
            // 
            this.relatorioEmprestimo.DataSetName = "RelatorioEmprestimo";
            this.relatorioEmprestimo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioEmprestimoBindingSource
            // 
            this.relatorioEmprestimoBindingSource.DataSource = this.relatorioEmprestimo;
            this.relatorioEmprestimoBindingSource.Position = 0;
            // 
            // relatorioEmprestimoBindingSource1
            // 
            this.relatorioEmprestimoBindingSource1.DataMember = "RelatorioEmprestimo";
            this.relatorioEmprestimoBindingSource1.DataSource = this.relatorioEmprestimoBindingSource;
            // 
            // relatorioEmprestimoTableAdapter
            // 
            this.relatorioEmprestimoTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 389);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioEmprestimoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioEmprestimoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource relatorioEmprestimoBindingSource;
        private RelatorioEmprestimo relatorioEmprestimo;
        private System.Windows.Forms.BindingSource relatorioEmprestimoBindingSource1;
        private RelatorioEmprestimoTableAdapters.RelatorioEmprestimoTableAdapter relatorioEmprestimoTableAdapter;
    }
}