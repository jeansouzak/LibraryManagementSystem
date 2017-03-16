using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Emprestimo.Model
{
    class EmprestimoDao : Connection.Dao<Emprestimo>
    {
        public List<Emprestimo> getItensEmprestadosPorAluno(Pessoa.Model.Aluno aluno)
        {
            try
            {
                List<Emprestimo> emprestimos = (from e in ctx.emprestimos
                            join i in ctx.itens on e.id equals i.emprestimo.id
                            where i.situacao == 1 && e.aluno.id == aluno.id                            
                            select e).ToList();
                            
                return emprestimos;                           

            }
            catch
            {
                return null;
            }
        }
        public Emprestimo getEmprestimoByIdWithDep(int id)
        {
            try
            {
                return this.ctx.emprestimos.Include("Itens").Where(e => e.id == id).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
    }
}
