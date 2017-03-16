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
    public partial class CategoriaFrame : Form
    {
        public Model.Categoria categoria { get; set; }
        private Model.CategoriaDao categoriaDao;

        public CategoriaFrame()
        {
            InitializeComponent();
            categoriaDao = new Model.CategoriaDao();
        }

        private void populateGrid(List<Model.Categoria> cs)
        {
            dataGrid.Rows.Clear();
            List<Model.Categoria> categorias = cs == null ? categoriaDao.getAll() : cs;
            foreach (Categoria.Model.Categoria c in categorias)
            {
                dataGrid.Rows.Add(c.id, c.nome);
            }

        }
        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            new Categoria.View.Formulario(App.CrudOpt.CADASTRAR).ShowDialog(this);
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {            
            if(!nomeTb.Text.Equals("")){
                List<Model.Categoria> categorias = categoriaDao.getCategoriasByName(nomeTb.Text);
                this.populateGrid(categorias);
             }
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                new Categoria.View.Formulario(App.CrudOpt.EDITAR).ShowDialog(this);
            }
            else
            {
                editarBtn.Enabled = false;
            }

        }

        private void CategoriaFrame_Load(object sender, EventArgs e)
        {
            this.populateGrid(null);
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editarBtn.Enabled = true;
            removerBtn.Enabled = true;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGrid.Rows[rowIndex];
            string id = row.Cells["idColumn"].Value.ToString();
            categoria = (Model.Categoria)categoriaDao.getById(int.Parse(id));     
        }
        public void clean()
        {
            editarBtn.Enabled = false;
            removerBtn.Enabled = false;
            nomeTb.Text = "";            
            categoria = null;
            this.populateGrid(null);
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                categoriaDao.delete(categoria);
                categoriaDao.saveChanges();
                MessageBox.Show("Removido com sucesso !");
                this.clean();
            }
            else
            {
                removerBtn.Enabled = false;
            }
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            this.clean();
        }
    }
}