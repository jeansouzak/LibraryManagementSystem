using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Emprestimo.Model
{
    public class Item
    {
        public int id { get; set; }
        public virtual Livro.Model.Livro livro { get; set; }
        public int situacao { get; set; }
        public float multa { get; set; }
        public virtual Emprestimo emprestimo { get; set; }
    }
}
