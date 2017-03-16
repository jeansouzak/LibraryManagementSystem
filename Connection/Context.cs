using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Biblioteca.Connection
{
    class Context : DbContext
    {
        public DbSet<Editora.Model.Editora> editoras { get; set; }
        public DbSet<Categoria.Model.Categoria> categorias { get; set; }
        public DbSet<Emprestimo.Model.Emprestimo> emprestimos { get; set; }
        public DbSet<Emprestimo.Model.Item> itens { get; set; }
        public DbSet<Endereco.Model.Endereco> enderecos { get; set; }
        public DbSet<Livro.Model.Livro> livros { get; set; }        
        public DbSet<Pessoa.Model.Pessoa> pessoas { get; set; }
        public DbSet<Pessoa.Model.Autor> autores { get; set; }
        public DbSet<Pessoa.Model.Aluno> alunos { get; set; }
        public DbSet<Pessoa.Model.Usuario> usuarios { get; set; }

    }
}
