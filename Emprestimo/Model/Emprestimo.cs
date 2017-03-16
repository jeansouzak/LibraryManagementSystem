using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Emprestimo.Model
{
    public class Emprestimo
    {
        public int id { get; set; }
        public virtual Pessoa.Model.Aluno aluno { get; set; }
        public virtual Pessoa.Model.Usuario usuario { get; set; }
        public DateTime dataSaida { get; set; }
        public DateTime dataEntrada { get; set; }
        public virtual List<Item> itens { get; set; }
    }
}
