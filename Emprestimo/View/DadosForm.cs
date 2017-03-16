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
    public partial class DadosForm : Form
    {
        private Emprestimo.Model.Emprestimo emprestimo;
        private List<Model.Item> itens;
        private int quantidadeDevolucao; 

        public DadosForm(Model.Emprestimo e)
        {
            InitializeComponent();
            this.emprestimo = e;
            this.itens = e.itens;
            this.quantidadeDevolucao = 0;
            this.calcularQuantidadeDevolucao();
        }
        private void calcularQuantidadeDevolucao()
        {
            foreach (Model.Item item in itens)
            {
                if (item.situacao == 1)
                {
                    quantidadeDevolucao++;
                }
            }
            
        }
        private void DadosForm_Load(object sender, EventArgs e)
        {
            if (e != null)
            {
                Pessoa.Model.Aluno aluno = emprestimo.aluno;
                alunoTb.Text = aluno.nome;
                matriculaTb.Text = aluno.matricula;
                int dias = 0;
                if (quantidadeDevolucao > 0)
                {
                    situacaoTb.Text = "Há itens para serem devolvidos !";
                    situacaoTb.ForeColor = Color.Red;
                    TimeSpan date = DateTime.Now - emprestimo.dataSaida;
                    dias = date.Days > 0 ? date.Days : 0;
                }
                else
                {
                    situacaoTb.Text = "Todos os itens foram devolvidos !";                    
                }

                float multa = App.BibliotecaConfig.VALOR_MULTA_DIA * dias;

                multaTb.Text = multa.ToString("C2");
                dataEntradaTb.Text = emprestimo.dataEntrada.ToShortDateString();
                dataDevolucaoTb.Text = emprestimo.dataSaida.ToShortDateString();
                foreach (Model.Item i in itens)
                {
                    livroListbox.Items.Add(i.livro);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
