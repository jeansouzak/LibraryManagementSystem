using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Model
{
    public class Usuario : Pessoa
    {
        public string login { get; set; }
        public string senha { get; set; }
    }
}
