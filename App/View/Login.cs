using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.App.View
{
    public partial class Login : Form
    {
        private Pessoa.Model.UsuarioDao usuarioDao;
        public Login()
        {
            InitializeComponent();
            usuarioDao = new Pessoa.Model.UsuarioDao();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            if (this.validate())
            {
                Pessoa.Model.Usuario user = usuarioDao.getUserByLoginAndSenha(loginTb.Text, senhaTb.Text);
                if (user != null)
                {
                    App.Service.Session.setUserLogged(user);
                    new mainFrame().Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos !");
                }
            }
        }
        private bool validate()
        {
            bool validated = true;
            if (loginTb.Text == "")
            {   
                validated = false;
            }
            if (senhaTb.Text == "")
            {
                validated = false;
            }
            return validated;
        }
        public void clear()
        {
            loginTb.Text = "";
            senhaTb.Text = "";
        }

        private void cadastroBtn_Click(object sender, EventArgs e)
        {
            new Pessoa.View.Formulario(CrudOpt.CADASTRAR).ShowDialog();
        }

       
    }
}
