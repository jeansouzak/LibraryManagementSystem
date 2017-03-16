using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Endereco.Model;

namespace Biblioteca.Editora.Model
{
    public class Editora
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string  telefone { get; set; }
        public virtual Endereco.Model.Endereco endereco { get; set; }
        public string cnpj { get; set; }

        public override string ToString()
        {
            return nome;
        }
    }
}
