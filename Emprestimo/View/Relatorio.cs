using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Emprestimo.View
{
    public partial class Relatorio : Form
    {
        private Emprestimo.Model.Emprestimo emprestimo;

        public Relatorio(Emprestimo.Model.Emprestimo e)
        {
            InitializeComponent();
            emprestimo = e;
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'relatorioEmprestimo.RelatorioEmprestimo' table. You can move, or remove it, as needed.
            this.relatorioEmprestimoTableAdapter.Fill(this.relatorioEmprestimo._RelatorioEmprestimo, emprestimo.id);

            this.reportViewer1.RefreshReport();
        }
    }
}
