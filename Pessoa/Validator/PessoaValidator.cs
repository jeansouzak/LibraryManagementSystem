using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Validator
{
    class PessoaValidator
    {
        private Model.PessoaDao pessoaDao;
        private Model.AlunoDao alunoDao;
        private Model.UsuarioDao usuarioDao;
        private CpfValidator cpfValidator;

        public PessoaValidator()
        {
            pessoaDao = new Model.PessoaDao();
            alunoDao = new Model.AlunoDao();
            usuarioDao = new Model.UsuarioDao();
            cpfValidator = new CpfValidator();
        }
        public bool validateLogin(string login)
        {
            if (usuarioDao.getUserByLogin(login) == null)
            {
                return true;
            }
                return false;
           
        }
        public bool validateMatricula(string matricula)
        {
            if (alunoDao.getAlunoByMatricula(matricula) == null)
            {
                return true;
            }
            
                return false;
            
               
        }
        public bool validateCpf(string cpf)
        {
            string cpfToValidation = cpf.Replace("-", "");
            if (cpfValidator.validarCpf(cpfToValidation))
            {
                return true;
            }
            return false;
        }
        public bool checkCpfExists(string cpf)
        {
            if (pessoaDao.getPessoaByCpf(cpf) == null)
            {
                return true;
            }
            return false;
        }
    }
}
