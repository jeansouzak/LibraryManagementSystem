using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Editora.Model
{
    class EditoraDao : Connection.Dao<Editora>
    {
        public List<Editora> getAllWithDep()
        {
            try
            {
                return this.ctx.editoras.Include("Endereco").ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<Editora> getAllWithLimit(int limit)
        {
            try
            {
                return this.ctx.editoras.Take(limit).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<Editora> findByNameOrCNJP(string nomeCnpj)
        {
            try
            {
                return this.ctx.editoras.Include("Endereco").Where(e => e.nome.Contains(nomeCnpj) || e.cnpj.Contains(nomeCnpj)).ToList();
            }
            catch
            {
                return null;
            }
        }
        public Editora findEditoraByCNPJ(string cnpj)
        {
            try
            {
                return this.ctx.editoras.Where(e => e.cnpj.Equals(cnpj)).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
    }
    
}
