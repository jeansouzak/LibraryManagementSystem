using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Model
{
    //Annotation entity framework (primeiro link)
    //[Table("Clientes")]
    public class Pessoa
    {
        //[Key]
        //[Column(Order=1)]
        //[Required(ErrorMessage="campo obrigatorio")]
        public int id { get; set; }
        public string nome { get; set; }        
        public DateTime? dataNascimento { get; set; }
        public virtual Endereco.Model.Endereco endereco { get; set; }
        public string cpf { get; set; }

        public override string ToString()
        {
            return nome;
        }
    }
}
