using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Editora.View
{
    public partial class Formulario : Form
    {
        private Editora.Model.EditoraDao editoraDao;
        private Editora.Model.Editora editora;
        private App.CrudOpt opt;

        public Formulario(App.CrudOpt opt)
        {
            InitializeComponent();
            editoraDao = new Model.EditoraDao();
            this.opt = opt;
        }
        private bool validateForm()
        {
            bool validated = true;
            if (nomeTb.Text.Equals(""))
            {
                nomeLb.ForeColor = Color.Red;
                validated = false;
            }
            else
            {
                nomeLb.ForeColor = Color.Black;
            }
            if (cnpjTb.Text.Equals(""))
            {
                cnpjLb.ForeColor = Color.Red;
                validated = false;
            }else if(opt != App.CrudOpt.EDITAR){
                Editora.Validator.EditoraValidator validator = new Validator.EditoraValidator();
                if (validator.checkCNPJExists(cnpjTb.Text))
                {
                    cnpjLb.ForeColor = Color.Red;
                    MessageBox.Show("CNPJ ja existente !");
                    validated = false;
                }
                
            }
            
            return validated;
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                Endereco.Model.Endereco endereco = new Endereco.Model.Endereco();
                endereco.cep = cepTb.Text;
                if (!numeroTb.Text.Equals(""))
                {
                    endereco.numero = int.Parse(numeroTb.Text);
                }

                if (opt == App.CrudOpt.CADASTRAR)
                {
                    editora = new Model.Editora();
                    editora.cnpj = cnpjTb.Text;
                    editora.nome = nomeTb.Text;
                    editora.telefone = telefoneTb.Text;
                    editora.endereco = endereco;
                    editoraDao.add(editora);
                }
                else
                {
                    editora.cnpj = cnpjTb.Text;
                    editora.nome = nomeTb.Text;
                    editora.telefone = telefoneTb.Text;
                    editora.endereco = endereco;
                    editoraDao.update(editora);
                }
                editoraDao.saveChanges();
                if (Owner != null)
                {
                    EditoraFrame ef = (EditoraFrame)Owner;
                    ef.clean();
                }
                MessageBox.Show("Salvo com sucesso !");
                this.Close();
            }
        }
        private void setData(Editora.Model.Editora e)
        {
            editora = e;
            nomeTb.Text = editora.nome;
            cnpjTb.Text = editora.cnpj;
            if (editora.endereco != null)
            {
                cepTb.Text = editora.endereco.cep;
                numeroTb.Text = editora.endereco.numero.ToString();
            }
            telefoneTb.Text = editora.telefone;

        }
        private void Formulario_Load(object sender, EventArgs e)
        {
            if (opt == App.CrudOpt.EDITAR)
            {
                EditoraFrame ef = (EditoraFrame)this.Owner;
                this.setData(ef.editora);
            }
        }
    }
}
