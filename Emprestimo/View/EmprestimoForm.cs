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
    public partial class EmprestimoForm : Form
    {
        private App.CrudOpt opt;
        private Emprestimo.Model.EmprestimoDao emprestimoDao;
        private Emprestimo.Model.ItemDao itemDao;
        private Livro.Model.LivroDao livroDao;
        private Pessoa.Model.AlunoDao alunoDao;
        public List<Livro.Model.Livro> livrosEmprestimo { get; set; }
        private Livro.Model.Livro livro;

        public EmprestimoForm(App.CrudOpt opt)
        {
            InitializeComponent();
            this.opt = opt;
            emprestimoDao = new Model.EmprestimoDao();
            itemDao = new Model.ItemDao();
            livroDao = new Livro.Model.LivroDao();
            alunoDao = new Pessoa.Model.AlunoDao();
            livrosEmprestimo = new List<Livro.Model.Livro>();
        }

        private bool validateForm()
        {
            bool validated = true;
            if (alunoCb.SelectedItem == null)
            {
                alunoLb.ForeColor = Color.Red;
                validated = false;
            }
            else
            {
                Emprestimo.Validator.EmprestimoValidator validator = new Validator.EmprestimoValidator();
                Pessoa.Model.Aluno aluno = (Pessoa.Model.Aluno) alunoCb.SelectedItem;
                if (validator.existsLivroEmprestado(aluno))
                {
                    alunoLb.ForeColor = Color.Red;
                    validated = false;
                    MessageBox.Show("Este aluno possui livros para devolver !");
                }              
            }
            if(!dataDevolucaoTb.MaskFull){
                devolucaoLb.ForeColor = Color.Red;
                validated = false;
            }
            if(livrosEmprestimo.Count == 0){
                MessageBox.Show("Voce deve selecionar pelo menos 1 livro para ser emprestado !");
                validated = false;
            }
            return validated;
        }
        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (opt == App.CrudOpt.CADASTRAR)
                {
                    List<Model.Item> itens = new List<Model.Item>();
                    Emprestimo.Model.Emprestimo emprestimo = new Model.Emprestimo();
                    emprestimo.aluno = (Pessoa.Model.Aluno)alunoCb.SelectedItem;
                    emprestimo.dataEntrada = DateTime.Now;
                    emprestimo.dataSaida = DateTime.Parse(dataDevolucaoTb.Text);
                    emprestimo.usuario = App.Service.Session.getUserLogged();
                    foreach (Livro.Model.Livro l in livrosEmprestimo)
                    {
                        Model.Item item = new Model.Item();
                        item.emprestimo = emprestimo;
                        item.livro = l;
                        //Emprestado
                        item.situacao = 1;
                        itens.Add(item);
                        l.quantidade -= 1;
                        livroDao.update(l);
                        livroDao.saveChanges();
                    }
                    emprestimo.itens = itens;
                    emprestimoDao.add(emprestimo);
                    emprestimoDao.saveChanges();
                    MessageBox.Show("Emprestimo realizado com sucesso, codigo gerado: " + emprestimo.id);
                    new Relatorio(emprestimo).ShowDialog();
                    this.Close();
                }
                
            }
        }

        private void alunoCb_TextChanged(object sender, EventArgs e)
        {
            string alunoTxt = alunoCb.Text;
            if (alunoTxt.Length > 3)
            {
                List<Pessoa.Model.Aluno> alunos = alunoDao.getAlunosByNameAndMatricula(alunoTxt);
                if (alunos != null && alunos.Count > 0)
                {
                 
                    alunoCb.DataSource = alunos;
                    var sText = alunoCb.Items[0].ToString();
                    alunoCb.SelectionStart = alunoTxt.Length;
                    alunoCb.SelectionLength = sText.Length - alunoTxt.Length;
                    alunoCb.DroppedDown = true;
                    return;
                }
                else
                {
                 
                    alunoCb.DroppedDown = false;
                    alunoCb.SelectionStart = alunoTxt.Length;
                }
            }
        }

        private void livroCb_TextChanged(object sender, EventArgs e)
        {
            string livroTxt = livroCb.Text;
            if (livroTxt.Length > 3)
            {
                List<Livro.Model.Livro> livros = livroDao.getLivroByNomeOrIsbnOrCategoria(livroTxt, null);
                if (livros != null && livros.Count > 0)
                {
                    addBtn.Enabled = true;
                    livroCb.DataSource = livros;
                    var sText = livroCb.Items[0].ToString();
                    livroCb.SelectionStart = livroTxt.Length;
                    livroCb.SelectionLength = sText.Length - livroTxt.Length;
                    livroCb.DroppedDown = true;
                    
                    livro = (Livro.Model.Livro) livroCb.SelectedItem;
                    if (livro.quantidade < 1)
                    {
                        MessageBox.Show("A quantidade do livro "+livro.nome+" em estoque não é suficiente para emprestimo");
                        livro = null;
                        addBtn.Enabled = false;
                    }
                    return;
                }
                else
                {
                    livro = null;
                    addBtn.Enabled = false;
                    livroCb.DroppedDown = false;
                    livroCb.SelectionStart = livroTxt.Length;
                }
            }
        }
        private void updateGrid()
        {
            dataGrid.Rows.Clear();
            
            foreach (Livro.Model.Livro l in this.livrosEmprestimo)
            {                
                dataGrid.Rows.Add(l.id, l.nome, l.autor.nome);
            
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (livro != null)
            {
                if (livro.quantidade > 0)
                {
                    this.livrosEmprestimo.Add(livro);
                    updateGrid();
                }
                else
                {
                    MessageBox.Show("Quantidade de livro insuficiente !");
                }
            }
            else
            {

                addBtn.Enabled = false;
            }
        }
    }
}
