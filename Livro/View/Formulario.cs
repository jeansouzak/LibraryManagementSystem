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
    public partial class Formulario : Form
    {
        private App.CrudOpt opt;
        private Livro.Model.LivroDao livroDao;
        private Pessoa.Model.AutorDao autorDao;
        private Categoria.Model.CategoriaDao categoriaDao;
        private Editora.Model.EditoraDao editoraDao;
        private Livro.Model.Livro livro;
        private bool enableComplete = true;

        public Formulario(App.CrudOpt opt)
        {
            InitializeComponent();
            this.opt = opt;
            livroDao = new Model.LivroDao();
            autorDao = new Pessoa.Model.AutorDao();
            categoriaDao = new Categoria.Model.CategoriaDao();
            editoraDao = new Editora.Model.EditoraDao();
        }
        private void setData(Model.Livro livro)
        {
            enableComplete = false;
            this.livro = livro;
            nomeTb.Text = livro.nome;
            isbnTb.Text = livro.isbn;
            edicaoTb.Text = livro.edicao;
            quantidadeNm.Value = livro.quantidade;
            object[] autores = new object[1] { livro.autor};

            autorCb.DataSource = autores;
            autorCb.SelectedItem = livro.autor;            
            if (livro.editora != null)
            {
                object[] editoras = new object[1] { livro.editora };
                editoraCb.DataSource = editoras;
                editoraCb.SelectedItem = livro.editora;
            }
            if (livro.categoria != null)
            {
                object[] categorias = new object[1] { livro.categoria };
                categoriaCb.DataSource = categorias;
                categoriaCb.SelectedItem = livro.categoria;
            }
            enableComplete = true;
        }
        private bool validateForm()
        {
            Livro.Validator.LivroValidator livroValidator = new Validator.LivroValidator();
            bool validated = true;
            if (nomeTb.Text.Equals(""))
            {
                nomeLb.ForeColor = Color.Red;
                validated = false;
            }
            if (isbnTb.Text.Equals(""))
            {
                isbnLb.ForeColor = Color.Red;
                validated = false;
            }else if(livroValidator.checkIsbnExists(isbnTb.Text) && opt != App.CrudOpt.EDITAR){                
                isbnLb.ForeColor = Color.Red;
                MessageBox.Show("ISBN Cadastrado já existente !");
                validated = false;
            }
            if (autorCb.SelectedItem == null)
            {
                autorLb.ForeColor = Color.Red;
                validated = false;
            }
            return validated;
        }
        
        private void enviarBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                Editora.Model.Editora editora = null;
                Categoria.Model.Categoria categoria = null;
                Pessoa.Model.Autor autor = (Pessoa.Model.Autor) autorCb.SelectedItem;

                if (categoriaCb.SelectedItem != null)
                {
                    categoria = (Categoria.Model.Categoria) categoriaCb.SelectedItem;
                }
                if (editoraCb.SelectedItem != null)
                {
                  editora = (Editora.Model.Editora) editoraCb.SelectedItem;
                }

                if (opt == App.CrudOpt.CADASTRAR)
                {
                    livro = new Model.Livro();
                    livro.nome = nomeTb.Text;
                    livro.isbn = isbnTb.Text;
                    livro.edicao = edicaoTb.Text;
                    livro.autor = autor;
                    livro.editora = editora;
                    livro.categoria = categoria;
                    livro.quantidade =(int) quantidadeNm.Value;
                    livroDao.add(livro);
                   
                }
                else
                {
                    livro.nome = nomeTb.Text;
                    livro.isbn = isbnTb.Text;
                    livro.edicao = edicaoTb.Text;
                    livro.autor = autor;
                    livro.editora = editora;
                    livro.categoria = categoria;
                    livro.quantidade =(int) quantidadeNm.Value;
                    livroDao.update(livro);
                }
                livroDao.saveChanges();
                if (Owner != null)
                {
                    LivroFrame lf = (LivroFrame)Owner;
                    lf.clean();
                }
                MessageBox.Show("Salvo com sucesso !");
                this.Close();
            }
        }

  
        private void showHelpAutoCompleteMessage()
        {
            MessageBox.Show("Nem todos os itens são carregados automaticamente. \n" +
                "Para selecionar digite o nome desejado que ele auto-completara.");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            showHelpAutoCompleteMessage();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            showHelpAutoCompleteMessage();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            showHelpAutoCompleteMessage();
        }

        private void categoriaCb_TextChanged(object sender, EventArgs e)
        {
            string categoriaTxt = categoriaCb.Text;
            if (categoriaTxt.Length > 3 && enableComplete)
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

        private void editoraCb_TextChanged(object sender, EventArgs e)
        {            
            string editoraTxt = editoraCb.Text;
            if (editoraTxt.Length > 3 && enableComplete)
            {
                List<Editora.Model.Editora> editoras = editoraDao.findByNameOrCNJP(editoraTxt);
                if (editoras != null && editoras.Count > 0)
                {
                    editoraCb.DataSource = editoras;
                    var sText = editoraCb.Items[0].ToString();
                    editoraCb.SelectionStart = editoraTxt.Length;
                    editoraCb.SelectionLength = sText.Length - editoraTxt.Length;
                    editoraCb.DroppedDown = true;
                    return;
                }
                else
                {
                    editoraCb.DroppedDown = false;
                    editoraCb.SelectionStart = editoraTxt.Length;
                }
            }
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (opt == App.CrudOpt.EDITAR)
            {
                LivroFrame livroFrame = (LivroFrame)this.Owner;
                this.setData(livroFrame.livro);
            }
        }

      

        private void autorCb_TextChanged_1(object sender, EventArgs e)
        {
            string autorTxt = autorCb.Text;
            if (autorTxt.Length > 3 && enableComplete)
            {
                List<Pessoa.Model.Autor> autores = autorDao.findAutorByName(autorTxt);
                if (autores != null && autores.Count > 0)
                {
                    autorCb.DataSource = autores;
                    var sText = autorCb.Items[0].ToString();
                    autorCb.SelectionStart = autorTxt.Length;
                    autorCb.SelectionLength = sText.Length - autorTxt.Length;
                    autorCb.DroppedDown = true;
                    return;
                }
                else
                {
                    autorCb.DroppedDown = false;
                    autorCb.SelectionStart = autorTxt.Length;
                }
            }
        }
    }
}
