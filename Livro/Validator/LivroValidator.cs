using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Livro.Validator
{
    class LivroValidator
    {
        private Livro.Model.LivroDao livroDao;

        public LivroValidator()
        {
            livroDao = new Model.LivroDao();
        }

        public bool checkIsbnExists(string isbn)
        {
            if (livroDao.getLivroByISBN(isbn) == null)
            {
                return false;
            }
            return true;
        }

    }
}
