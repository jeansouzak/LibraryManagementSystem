using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Livro.View
{
    public partial class LivroFrame : Form
    {
        private Model.LivroDao livroDao;
        public Model.Livro livro { get; set; }
        public List<Model.Livro> livros { get; set; }
        private Categoria.Model.CategoriaDao categoriaDao;

        public LivroFrame()
        {
            InitializeComponent();
            livroDao = new Model.LivroDao();
            categoriaDao = new Categoria.Model.CategoriaDao();
        }
        private void populateGrid(List<Livro.Model.Livro> ls)
        {
            dataGrid.Rows.Clear();
            List<Livro.Model.Livro> livros = ls == null ? livroDao.getAllWithDep() : ls;
            foreach (Livro.Model.Livro l in livros)
            {
                string nome = l.nome;
                string nomeAutor = l.autor != null ? l.autor.nome : "";
                string nomeEditora = l.editora != null ? l.editora.nome : "";
                string edicao = l.edicao;
                int quantidade = l.quantidade;
                dataGrid.Rows.Add(l.id, nome, nomeAutor, nomeEditora, edicao, quantidade);
            }

        }
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string livroTxt = livroTb.Text;
            Categoria.Model.Categoria cat = (Categoria.Model.Categoria) categoriaCb.SelectedItem;
            List<Model.Livro> livros = livroDao.getLivroByNomeOrIsbnOrCategoria(livroTxt, cat);
            if (livros.Count > 0)
            {
                this.populateGrid(livros);
            }
            else
            {
                MessageBox.Show("Livro não encontrado !");
            }
        }

        private void LivroFrame_Load(object sender, EventArgs e)
        {            

            this.populateGrid(livros);
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            new Formulario(App.CrudOpt.CADASTRAR).ShowDialog(this);
        }
        public void clean()
        {
            editarBtn.Enabled = false;
            removerBtn.Enabled = false;
            livroTb.Text = "";
            categoriaCb.SelectedIndex = -1;
            livro = null;
            this.populateGrid(null);
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            this.clean();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editarBtn.Enabled = true;
            removerBtn.Enabled = true;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGrid.Rows[rowIndex];
            string id = row.Cells["idColumn"].Value.ToString();
            livro = (Model.Livro)livroDao.getById(int.Parse(id));
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (livro != null)
            {
                Formulario livroForm = new Formulario(App.CrudOpt.EDITAR);
                livroForm.ShowDialog(this);
            }
            else
            {
                editarBtn.Enabled = false;
            }
        }
        private void showHelpAutoCompleteMessage()
        {
            MessageBox.Show("Nem todos os itens são carregados automaticamente. \n" +
                "Para selecionar digite o nome desejado que ele auto-completara.");
        }
        private void label9_Click(object sender, EventArgs e)
        {
            showHelpAutoCompleteMessage();
        }

        private void categoriaCb_TextChanged(object sender, EventArgs e)
        {
            string categoriaTxt = categoriaCb.Text;
            if (categoriaTxt.Length > 3)
            {
                List<Categoria.Model.Categoria> categorias = categoriaDao.getCategoriasByName(categoriaTxt);
                if (categorias != null && categorias.Count > 0)
                {
                    categoriaCb.DataSource = categorias;
                    var sText = categoriaCb.Items[0].ToString();
                    categoriaCb.SelectionStart = categoriaTxt.Length;
                    categoriaCb.SelectionLength = sText.Length - categoriaTxt.Length;
                    categoriaCb.DroppedDown = true;
                    return;
                }
                else
                {
                    categoriaCb.DroppedDown = false;
                    categoriaCb.SelectionStart = categoriaTxt.Length;
                }
            }
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            if (livro != null)
            {
                livroDao.delete(livro);
                livroDao.saveChanges();
                this.clean();
            }
            else
            {
                removerBtn.Enabled = false;
            }
        }
    }
}
