using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Categoria.Model
{
    class CategoriaDao : Connection.Dao<Categoria>
    {
        public Categoria getCategoriaByName(string nome)
        {
            try
            {
                return this.ctx.categorias.Where(c => c.nome.Equals(nome)).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public List<Categoria> getAllWithLimit(int limit)
        {
            try
            {
                return this.ctx.categorias.Take(limit).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<Categoria> getCategoriasByName(string nome)
        {
            try
            {
                return this.ctx.categorias.Where(c => c.nome.Contains(nome)).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
