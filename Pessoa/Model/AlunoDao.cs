using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Model
{
    class AlunoDao : Connection.Dao<Aluno>
    {
        public Aluno getAlunoByMatricula(string matricula)
        {
            try
            {
                return this.ctx.alunos.Where(a => a.matricula.Equals(matricula)).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<Aluno> getAlunosByNameAndMatricula(string nome)
        {
            try
            {
                return this.ctx.alunos.Where(a => (a.nome.Contains(nome) || a.matricula.Contains(nome))).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
