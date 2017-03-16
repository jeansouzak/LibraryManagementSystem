using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Emprestimo.Validator
{
    class EmprestimoValidator
    {
        private Emprestimo.Model.EmprestimoDao emprestimoDao;

        public EmprestimoValidator()
        {
            emprestimoDao = new Model.EmprestimoDao();
        }

        public bool existsLivroEmprestado(Pessoa.Model.Aluno aluno)
        {
            List<Emprestimo.Model.Emprestimo> es = emprestimoDao.getItensEmprestadosPorAluno(aluno);
            if (es == null)
            {
                //Possui livro para ser devolvido
                return true;
            }
            else if (es.Count > 0)
            {
                return true;
            }
            //Nao tem livro para ser devolvido
            return false;
        }
    }
}
