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
    public partial class EditoraFrame : Form
    {
        public Editora.Model.Editora editora { get; set; }
        private Editora.Model.EditoraDao editoraDao;

        public EditoraFrame()
        {
            InitializeComponent();
            editoraDao = new Model.EditoraDao();
        }
        
        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            new Editora.View.Formulario(App.CrudOpt.CADASTRAR).ShowDialog(this);
        }
        public void clean()
        {
            editarBtn.Enabled = false;
            removerBtn.Enabled = false;
            nomeTb.Text = "";
            editora = null;
            this.populateGrid(null);
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (!nomeTb.Text.Equals(""))
            {
                List<Model.Editora> editoras = editoraDao.findByNameOrCNJP(nomeTb.Text);
                if (editoras.Count > 0)
                {
                    populateGrid(editoras);
                }

            }
        }
        private void populateGrid(List<Model.Editora> eds)
        {
            dataGrid.Rows.Clear();
            List<Editora.Model.Editora> editoras = eds == null ? editoraDao.getAllWithDep() : eds;
            foreach (Editora.Model.Editora e in editoras)
            {
                string cep = e.endereco != null ? e.endereco.cep : "";
                dataGrid.Rows.Add(e.id, e.nome, e.telefone, e.cnpj, cep);
            }
        }
     
        private void EditoraFrame_Load(object sender, EventArgs e)
        {
            this.populateGrid(null);
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (editora != null)
            {
                new View.Formulario(App.CrudOpt.EDITAR).ShowDialog(this);
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

        private void dataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            editarBtn.Enabled = true;
            removerBtn.Enabled = true;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGrid.Rows[rowIndex];
            string id = row.Cells["idColumn"].Value.ToString();
            editora = (Model.Editora)editoraDao.getById(int.Parse(id));
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            if (editora != null)
            {
                editoraDao.delete(editora);
                editoraDao.saveChanges();
                MessageBox.Show("Removido com sucesso !");
                this.clean();
            }
        }
    }
}
