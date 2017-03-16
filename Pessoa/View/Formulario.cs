using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Pessoa.View
{
    public partial class Formulario : Form
    {
        private App.CrudOpt opt;
        private Pessoa.Model.Pessoa pessoa;
        private Pessoa.Model.Pessoa pessoaWithoutModify;
        private Pessoa.Model.PessoaDao pessoaDao;
        private Pessoa.Model.UsuarioDao usuarioDao;
        private Pessoa.Model.AlunoDao alunoDao;
        private Pessoa.Model.AutorDao autorDao;
        private Pessoa.Validator.PessoaValidator pessoaValidator;

        public Formulario(App.CrudOpt opt)
        {
            InitializeComponent();
            this.opt = opt;
            usuarioDao = new Model.UsuarioDao();
            alunoDao = new Model.AlunoDao();
            autorDao = new Model.AutorDao();
            pessoaDao = new Model.PessoaDao();
            pessoaValidator = new Validator.PessoaValidator();
        }

        private void tipoCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleFields();
        }
        private void handleFields()
        {
            string tipo = tipoCb.SelectedItem.ToString();
            switch (tipo.ToLower())
            {
                case "usuário":
                    matriculaTb.Enabled = false;
                    siteTb.Enabled = false;
                    loginTb.Enabled = true;
                    senhaTb.Enabled = true;
                    loginLb.Text += " *";
                    senhaLb.Text += " *";
                    matriculaLb.Text = matriculaLb.Text.Replace(" *", "");
                    //O patch abaixo foi feito para o caso de edição e criação
                    //de qualquer tipo de pessoa no mesmo formulario

                    //Se nao for nulo
                    if (pessoa != null)
                    {
                        //Se o tipo for diferente de usuario
                        if (pessoa.GetType() != typeof(Model.Usuario))
                        {
                            //Troca para usuario, criando uma nova instancia
                            pessoa = new Model.Usuario();
                        }
                    }
                    else
                    {
                        //Caso seja nulo instancia um novo usuario
                        pessoa = new Model.Usuario();
                    }
                    break;
                case "aluno":
                    siteTb.Enabled = false;
                    loginTb.Enabled = false;
                    senhaTb.Enabled = false;
                    matriculaTb.Enabled = true;
                    if (pessoa != null)
                    {
                        if (pessoa.GetType() != typeof(Model.Aluno))
                        {
                            pessoa = new Model.Aluno();
                        }
                    }
                    else
                    {                       
                        pessoa = new Model.Aluno();
                    }
                    loginLb.Text = loginLb.Text.Replace(" *", "");
                    senhaLb.Text = senhaLb.Text.Replace(" *", "");;
                    matriculaLb.Text += " *";
                    break;
                case "autor":
                    siteTb.Enabled = true;
                    loginTb.Enabled = false;
                    senhaTb.Enabled = false;
                    matriculaTb.Enabled = false;
                    if (pessoa != null)
                    {
                        if (pessoa.GetType() != typeof(Model.Autor))
                        {
                            pessoa = new Model.Autor();
                        }
                    }
                    else
                    {
                        pessoa = new Model.Autor();
                    }
                    loginLb.Text = loginLb.Text.Replace(" *", "");
                    senhaLb.Text = senhaLb.Text.Replace(" *", "");
                    matriculaLb.Text = matriculaLb.Text.Replace(" *", "");
                    break;
                default:
                    siteTb.Enabled = false;
                    loginTb.Enabled = false;
                    senhaTb.Enabled = false;
                    matriculaTb.Enabled = false;
                    pessoa = null;
                    break;
            }
        }
        
        private bool validateForm()
        {
            bool validated = true;
            
            if (nomeTb.Text.Equals(""))
            {
                nomeLb.ForeColor = Color.Red;               
                validated = false;
            }
            
            if (tipoCb.SelectedItem == null)
            {
                tipoLb.ForeColor = Color.Red;               
                validated = false;
            }
            else
            {
                if (!pessoaValidator.checkCpfExists(cpfTb.Text) && opt != App.CrudOpt.EDITAR)
                {
                    cpfLb.ForeColor = Color.Red;
                    MessageBox.Show("Cpf ja existente!");
                    validated = false;
                }
                if (!pessoaValidator.validateCpf(cpfTb.Text))
                {
                    cpfLb.ForeColor = Color.Red;
                    MessageBox.Show("Cpf invalido!");
                    validated = false;
                }
                if (!pessoa.GetType().Name.Contains(typeof(Pessoa.Model.Autor).Name))
                {
                    if (!cpfTb.MaskFull)
                    {
                        cpfLb.ForeColor = Color.Red;
                        validated = false;
                    }
                }
                if (pessoa.GetType().Name.Contains(typeof(Pessoa.Model.Usuario).Name))
                {
                    if (loginTb.Text.Equals(""))
                    {
                        tipoLb.ForeColor = Color.Black;
                        matriculaLb.ForeColor = Color.Black; 
                        loginLb.ForeColor = Color.Red;       
                        validated = false;
                    }
                    if (senhaTb.Text.Equals(""))
                    {
                        tipoLb.ForeColor = Color.Black;
                        matriculaLb.ForeColor = Color.Black; 
                        senhaLb.ForeColor = Color.Red;       
                        validated = false;
                    }
                    if (!pessoaValidator.validateLogin(loginTb.Text) && opt != App.CrudOpt.EDITAR)
                    {
                        loginLb.ForeColor = Color.Red;
                        MessageBox.Show("Login ja existente!");
                        validated = false;
                    }
                    

                }
                else if (pessoa.GetType().Name.Contains(typeof(Pessoa.Model.Aluno).Name))
                {
                    if (matriculaTb.Text.Equals(""))
                    {
                        loginLb.ForeColor = Color.Black;
                        senhaLb.ForeColor = Color.Black;
                        tipoLb.ForeColor = Color.Black;
                        matriculaLb.ForeColor = Color.Red;
                        validated = false;
                    }
                    if (!pessoaValidator.validateMatricula(matriculaTb.Text) && opt != App.CrudOpt.EDITAR)
                    {
                        matriculaLb.ForeColor = Color.Red;
                        MessageBox.Show("Matricula ja existente!");
                        validated = false;
                    }
                }
                else
                {
                    cpfLb.ForeColor = Color.Black;
                    loginLb.ForeColor = Color.Black;
                    senhaLb.ForeColor = Color.Black;
                    matriculaLb.ForeColor = Color.Black;
                }
            }
            return validated;
        }
        
        private void enviarBtn_Click(object sender, EventArgs e)
        {
            if (this.validateForm())
            {                
                Endereco.Model.Endereco endereco = new Endereco.Model.Endereco();
                pessoa.nome = nomeTb.Text;
                pessoa.cpf = cpfTb.Text;
                endereco.cep = cepTb.Text;
                if (dataNascimentoTb.MaskFull)
                {
                    pessoa.dataNascimento = DateTime.Parse(dataNascimentoTb.Text);
                }
                if (!numeroTb.Text.Equals(""))
                {
                    endereco.numero = int.Parse(numeroTb.Text);
                }

                pessoa.endereco = endereco;

                if (pessoa.GetType().Name.Contains(typeof(Pessoa.Model.Usuario).Name))
                {
                    Model.Usuario usuario = (Model.Usuario) pessoa;
                    usuario.login = loginTb.Text;
                    usuario.senha = senhaTb.Text;
                    if (opt == App.CrudOpt.CADASTRAR)
                    {
                        pessoaDao.add(usuario);                        
                    }
                    else
                    {
                        if (pessoaWithoutModify.GetType() != usuario.GetType())
                        {
                            pessoaDao.delete(pessoaWithoutModify);
                            pessoaDao.add(usuario);
                        }
                        else
                        {
                            pessoaDao.update(usuario);
                        }

                    }
                    pessoaDao.saveChanges(); 

                    
                }
                else if (pessoa.GetType().Name.Contains(typeof(Pessoa.Model.Aluno).Name))
                {
                    Model.Aluno aluno = (Model.Aluno) pessoa;
                    aluno.matricula = matriculaTb.Text;
                    if (opt == App.CrudOpt.CADASTRAR)
                    {
                        pessoaDao.add(aluno);
                    }
                    else
                    {
                        if (pessoaWithoutModify.GetType() != aluno.GetType())
                        {
                            pessoaDao.delete(pessoaWithoutModify);
                            pessoaDao.add(aluno);
                        }
                        else
                        {
                            pessoaDao.update(aluno);
                        }
                        
                    }
                    pessoaDao.saveChanges();
                }
                else
                {
                    Model.Autor autor = (Model.Autor) pessoa;
                    autor.site = siteTb.Text;
                    if (opt == App.CrudOpt.CADASTRAR)
                    {
                        pessoaDao.add(autor);
                    }
                    else
                    {
               
                        if (pessoaWithoutModify.GetType() != autor.GetType())
                        {
                            pessoaDao.delete(pessoaWithoutModify);
                            pessoaDao.add(autor);
                        }
                        else
                        {
                            pessoaDao.update(autor);
                        }
                    }
                    pessoaDao.saveChanges();
                }
                if (Owner != null)
                {
                    PessoaForm pf = (PessoaForm)Owner;
                    pf.clean();
                }
                MessageBox.Show("Salvo com sucesso !");
                this.Close();
                
            }
        }
        private void setData(Pessoa.Model.Pessoa p)
        {
            pessoa = p;
            pessoaWithoutModify = p;
            nomeTb.Text = p.nome;
            cpfTb.Text = p.cpf;
            dataNascimentoTb.Text = p.dataNascimento.ToString();
            cepTb.Text = p.endereco != null ? p.endereco.cep : "";
            numeroTb.Text = p.endereco != null ? p.endereco.numero.ToString() : "";

            if (p.GetType().Name.Contains(typeof(Pessoa.Model.Aluno).Name))
            {
                tipoCb.SelectedItem = "Aluno";
                Pessoa.Model.Aluno aluno = (Model.Aluno) alunoDao.getById(p.id);
                matriculaTb.Text = aluno.matricula;
            }
            else if (p.GetType().Name.Contains(typeof(Pessoa.Model.Usuario).Name))
            {
                tipoCb.SelectedItem = "Usuário";
                Model.Usuario usuario = (Model.Usuario)usuarioDao.getById(p.id);
                loginTb.Text = usuario.login;
                senhaTb.Text = usuario.senha;
            }
            else
            {
                tipoCb.SelectedItem = "Autor";
                Model.Autor autor = (Model.Autor)autorDao.getById(p.id);                
                siteTb.Text = autor.site;
            }

            handleFields();
        }
        private void numeroTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            if (opt == App.CrudOpt.EDITAR)
            {               
                PessoaForm pessoaForm = (PessoaForm) this.Owner;
                this.setData(pessoaForm.pessoa);
            }
        }
        

      
        
    }
}
