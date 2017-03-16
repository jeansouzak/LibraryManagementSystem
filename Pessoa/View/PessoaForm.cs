using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Pessoa.View
{
    public partial class PessoaForm : Form
    {
        private Model.PessoaDao pessoaDao;
        public Model.Pessoa pessoa { get; set; }

        public PessoaForm()
        {
            InitializeComponent();
            pessoaDao = new Model.PessoaDao();
          
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            new Pessoa.View.Formulario(App.CrudOpt.CADASTRAR).ShowDialog(this);
        }
        private void populateGrid(List<Pessoa.Model.Pessoa> ps)
        {
            dataGrid.Rows.Clear();
            List<Pessoa.Model.Pessoa> pessoas = ps == null ?  pessoaDao.getAllWithDep() : ps;            
            foreach (Pessoa.Model.Pessoa p in pessoas)
            {
                string cep = p.endereco != null ? p.endereco.cep : "";
                dataGrid.Rows.Add(p.id, p.nome, p.cpf, cep, this.getTipoPessoa(p));
            }
            
        }
        private string getTipoPessoa(Pessoa.Model.Pessoa p)
        {          
            if (p.GetType().Name.Contains(typeof(Pessoa.Model.Usuario).Name))
            {
                return "Usuário";
            }
            else if (p.GetType().Name.Contains(typeof(Pessoa.Model.Aluno).Name))
            {
                return "Aluno";
            }
            else
            {
                return "Autor";
            }
        }
        private void PessoaForm_Load(object sender, EventArgs e)
        {
            this.populateGrid(null);
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string tipoPessoa = (string) tipoCb.SelectedItem;
            List<Pessoa.Model.Pessoa> pessoas = pessoaDao.getByNameAndType(tipoPessoa, nomeTb.Text);
            populateGrid(pessoas);
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editarBtn.Enabled = true;
            removerBtn.Enabled = true;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGrid.Rows[rowIndex];
            string id = row.Cells["idColumn"].Value.ToString();
            pessoa = (Model.Pessoa) pessoaDao.getById(int.Parse(id));                   
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (pessoa != null)
            {
               Formulario pessoaForm = new Pessoa.View.Formulario(App.CrudOpt.EDITAR);               
               pessoaForm.ShowDialog(this);
            }
            else
            {
                editarBtn.Enabled = false;
            }
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            this.clean();
        }
        
        public void clean()
        {
            editarBtn.Enabled = false;
            removerBtn.Enabled = false;
            nomeTb.Text = "";
            tipoCb.SelectedIndex = -1;
            pessoa = null;
            this.populateGrid(null);
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            if (pessoa != null)
            {
                pessoaDao.delete(pessoa);
                pessoaDao.saveChanges();
                this.clean();
            }
            else
            {
                removerBtn.Enabled = false;
            }
        }

        
    }
}
