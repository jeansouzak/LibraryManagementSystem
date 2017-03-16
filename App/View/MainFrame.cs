using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class mainFrame : Form
    {
        private Livro.Model.LivroDao livroDao;

        public mainFrame()
        {
            InitializeComponent();
            dataHoraTimer.Start();
            livroDao = new Livro.Model.LivroDao();            
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Pessoa.View.PessoaForm().ShowDialog();
        }

        private void livroTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastramentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Pessoa.View.Formulario(App.CrudOpt.CADASTRAR).ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Livro.View.LivroFrame().ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Livro.View.Formulario(App.CrudOpt.CADASTRAR).ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Emprestimo.View.EmprestimoForm(App.CrudOpt.CADASTRAR).ShowDialog();
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Emprestimo.View.DevolucaoForm().ShowDialog();
        }

        private void dataHoraTimer_Tick(object sender, EventArgs e)
        {
            updateTimer();
        }
        private void updateTimer()
        {
            DateTime dateNow = DateTime.Now;
            dataHoraLabel.Text = dateNow.ToString("dddd, d") + " de " + dateNow.ToString("MMMM") + " de " + dateNow.ToString("yyyy HH:mm:ss");
        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new App.View.About().ShowDialog();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            Livro.View.LivroFrame livroFrame = new Livro.View.LivroFrame();
            if (!livroTb.Text.Equals(""))
            {
                livroFrame.livros = livroDao.getLivroByNomeOrIsbnOrCategoria(livroTb.Text, null);
                livroFrame.ShowDialog();
            }
        }

        private void mainFrame_Load(object sender, EventArgs e)
        {
            this.validateUser();
            
            
        }
        public void validateUser()
        {
            Pessoa.Model.Usuario usuario = App.Service.Session.getUserLogged();
            if (usuario == null)
            {
                new App.View.Login().ShowDialog();
                this.Visible = false;
            }
            else
            {
                usuarioLogadoLabel.Text = usuario.nome;
                updateTimer();
            }
        }

        private void mainFrame_Shown(object sender, EventArgs e)
        {
            this.validateUser();
        }

        private void mainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Categoria.View.CategoriaFrame().ShowDialog();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Categoria.View.Formulario(App.CrudOpt.CADASTRAR).ShowDialog();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Editora.View.EditoraFrame().ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Editora.View.Formulario(App.CrudOpt.CADASTRAR).ShowDialog();
        }

        private void novoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            new Editora.View.Formulario(App.CrudOpt.CADASTRAR).ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
