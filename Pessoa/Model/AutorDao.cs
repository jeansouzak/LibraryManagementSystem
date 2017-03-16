using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Model
{
    class AutorDao : Connection.Dao<Autor>
    {
        public List<Autor> findAutorByName(string name)
        {
            try
            {
                return this.ctx.autores.Where(au => au.nome.Contains(name)).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<Autor> getAllWithLimit(int limit)
        {
            try
            {
                return this.ctx.autores.Take(limit).ToList();
            }
            catch
            {
                return null;
            }
        }
        
    }
}
