using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Livro.Model
{
    public class Livro
    {
        public int id { get; set; }
        public string nome { get; set; }
        public virtual Categoria.Model.Categoria categoria { get; set; }
        public virtual Editora.Model.Editora editora { get; set; }
        public virtual Pessoa.Model.Autor autor { get; set; }
        public string edicao { get; set; }
        public string isbn { get; set; }
        public int quantidade { get; set; }

        public override string ToString()
        {
            return nome;
        }
    }
}
