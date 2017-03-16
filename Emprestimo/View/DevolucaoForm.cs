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
    public partial class DevolucaoForm : Form
    {
        private Emprestimo.Model.EmprestimoDao emprestimoDao;
        private Emprestimo.Model.Emprestimo emprestimo;
        private Emprestimo.Model.ItemDao itemDao;

        public DevolucaoForm()
        {
            InitializeComponent();
            emprestimoDao = new Model.EmprestimoDao();
            emprestimo = new Model.Emprestimo();
            itemDao = new Model.ItemDao();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            emprestimo = (Model.Emprestimo) emprestimoDao.getEmprestimoByIdWithDep(int.Parse(codigoTb.Text));
            if (emprestimo != null)
            {
                consultarBtn.Enabled = true;
                this.populateItensEmprestimo();
            }
            else
            {
                MessageBox.Show("Emprestimo nao encontrado !");
            }
        }
        private void populateItensEmprestimo(){
            dataGrid.Rows.Clear();
            int rowIndex = 0;

            foreach (Model.Item item in emprestimo.itens)
            {
                Model.Item i = (Model.Item) itemDao.getItemByIdWithDep(item.id);
                dataGrid.Rows.Add(i.id, i.livro.nome, i.livro.autor.nome,
                    i.livro.editora != null ? i.livro.editora.nome : "", i.livro.edicao);

                DataGridViewRow row = dataGrid.Rows[rowIndex];
                

                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[5];
                if (i.situacao == 0)
                {                      
                    chk.Value = true;                    
                }
                else
                {
                    chk.Value = false;
                }
                rowIndex++;
            }
            
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGrid.Rows[rowIndex];
            string id = row.Cells["idColumn"].Value.ToString();
            DataGridViewCheckBoxCell chk = row.Cells[5] as DataGridViewCheckBoxCell;
            bool state = (bool) chk.EditedFormattedValue;
            Model.Item i = (Model.Item) itemDao.getById(int.Parse(id));
            //emprestimo.itens.Remove(i);
            if(state){
                //Devolvido
                i.situacao = 0;
                i.livro.quantidade += 1;
            }else{
                //Emprestado
                i.situacao = 1;
                i.livro.quantidade -= 1;
            }
            
            i.emprestimo = emprestimo;
            itemDao.update(i);
            itemDao.saveChanges();
            //emprestimo.itens.Add(i);
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            if (emprestimo != null)
            {
                new DadosForm(emprestimo).ShowDialog(this);
            }
        }
    }
}
