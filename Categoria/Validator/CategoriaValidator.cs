using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Categoria.Validator
{
    class CategoriaValidator
    {
        private Categoria.Model.CategoriaDao categoriaDao;

        public CategoriaValidator()
        {
            categoriaDao = new Model.CategoriaDao();
        }
        public bool validateNome(string nome)
        {
            if (categoriaDao.getCategoriaByName(nome) == null)
            {
                return true;
            }
            return false;
        }
    }
}
