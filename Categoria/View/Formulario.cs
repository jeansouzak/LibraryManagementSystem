using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Categoria.View
{
    public partial class Formulario : Form
    {
        private App.CrudOpt opt;
        private Categoria.Validator.CategoriaValidator categoriaValidator;
        private Categoria.Model.CategoriaDao categoriaDao;
        private Categoria.Model.Categoria categoria;

        public Formulario(App.CrudOpt opt)
        {
            InitializeComponent();
            this.opt = opt;
            categoriaValidator = new Validator.CategoriaValidator();
            categoriaDao = new Model.CategoriaDao();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (opt == App.CrudOpt.EDITAR)
            {
                CategoriaFrame catFrame = (CategoriaFrame)this.Owner;
                this.setData(catFrame.categoria);
            }
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (opt == App.CrudOpt.CADASTRAR)
                {
                    categoria = new Model.Categoria();
                    categoria.nome = nomeTb.Text;
                    categoriaDao.add(categoria);
                }
                else
                {
                    categoria.nome = nomeTb.Text;
                    categoriaDao.update(categoria);
                }
                categoriaDao.saveChanges();
                if (Owner != null)
                {
                    CategoriaFrame cf = (CategoriaFrame)Owner;
                    cf.clean();
                }
                MessageBox.Show("Salvo com sucesso !");
                this.Close();
            }
            
            
            
        }
        private bool validateForm()
        {
            if(nomeTb.Text.Equals(""))
            {
                nomeLb.ForeColor = Color.Red;
                return false;

            }else if(!categoriaValidator.validateNome(nomeTb.Text)){
                nomeLb.ForeColor = Color.Red;
                MessageBox.Show("Nome da categoria ja existente !");
                return false;
            }            

            return true;
        }
        private void setData(Categoria.Model.Categoria c)
        {
            this.categoria = c;
            nomeTb.Text = c.nome;
        }

    }
}
