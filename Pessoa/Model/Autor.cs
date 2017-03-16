using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Model
{
    public class Autor : Pessoa
    {
        public string site { get; set; }

        public override string ToString()
        {
            return nome;
        }
    }
}
