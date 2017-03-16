using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Editora.Validator
{
    class EditoraValidator
    {
        private Editora.Model.EditoraDao editoraDao;

        public EditoraValidator()
        {
            editoraDao = new Model.EditoraDao();
        }
        public bool checkCNPJExists(string cnpj)
        {
            if (editoraDao.findEditoraByCNPJ(cnpj) == null)
            {
                return false;
            }
            return true;
        }
    }
}
