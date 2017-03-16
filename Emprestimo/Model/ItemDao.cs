using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Emprestimo.Model
{
    class ItemDao : Connection.Dao<Item>
    {
        public Model.Item getItemByIdWithDep(int id)
        {
            return this.ctx.itens.Include("Livro").Where(i => i.id == id).FirstOrDefault();
        }
    }
}
