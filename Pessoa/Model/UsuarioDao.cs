using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Pessoa.Model
{
    class UsuarioDao : Connection.Dao<Usuario>
    {
       
        public Usuario getUserByLoginAndSenha(string login, string senha)
        {
            try
            {
                Usuario usuario = this.ctx.usuarios.Where(u => u.login.Equals(login) && u.senha.Equals(senha)).FirstOrDefault();
                return usuario;
            }
            catch
            {
                return null;
            }
        }
        public Usuario getUserByLogin(string login)
        {
            try
            {
                return this.ctx.usuarios.Where(u => u.login.Equals(login)).FirstOrDefault();
            }
            catch
            {
                return null;
            }

        }
    }
}
