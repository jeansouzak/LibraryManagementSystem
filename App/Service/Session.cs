using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App.Service
{
    class Session
    {
        public static string USER_LOGGED_KEY = "USUARIO_LOGADO";
        public static Dictionary<String, object> registers = new Dictionary<string,object>();

        public static Pessoa.Model.Usuario getUserLogged()
        {
            try
            {
                Pessoa.Model.Usuario usuarioLogado = (Pessoa.Model.Usuario) registers[App.Service.Session.USER_LOGGED_KEY];
                return usuarioLogado;
            }
            catch
            {
                return null;
            }
        }
        public static void setUserLogged(Pessoa.Model.Usuario usuario)
        {
            registers.Add(USER_LOGGED_KEY, usuario);
        }
    }
}
