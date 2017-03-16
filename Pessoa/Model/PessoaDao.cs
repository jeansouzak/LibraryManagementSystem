using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Model
{
    class PessoaDao : Connection.Dao<Pessoa>
    {
        public List<Pessoa> getAllWithDep()
        {
            try
            {
                return this.ctx.pessoas.Include("Endereco").ToList();
            }
            catch
            {
                return null;
            }
        }
       
        public List<Pessoa> getByNameAndType(string personType, string nome)
        {
            List<Pessoa> pessoas;
            if (personType == null)
            {
                return this.ctx.pessoas.Include("Endereco").Where(p => p.nome.Contains(nome)).ToList();
            }
            if(personType.Equals("Usuário")){
                pessoas = this.ctx.pessoas.Include("Endereco").Where(p => p.nome.Contains(nome) && p is Usuario).ToList();
            }
            else if (personType.Equals("Aluno"))
            {
                pessoas = this.ctx.pessoas.Include("Endereco").Where(p => p.nome.Contains(nome) && p is Aluno).ToList();
            }
            else
            {
                pessoas = this.ctx.pessoas.Include("Endereco").Where(p => p.nome.Contains(nome) && p is Autor).ToList();
            }
            
            return pessoas;
        }
        public Pessoa getPessoaByCpf(string cpf)
        {
            try
            {
                return this.ctx.pessoas.Where(p => p.cpf.Equals(cpf)).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

    }
}
