using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Livro.Model
{
    class LivroDao : Connection.Dao<Livro>
    {
        public Livro getLivroByISBN(string isbn)
        {
            try
            {
                return this.ctx.livros.Where(l => l.isbn.Equals(isbn)).FirstOrDefault();
            }
            catch
            {
                return null; 
            }
        }
        public List<Livro> getLivroByNomeOrIsbnOrCategoria(string nomeIsbn, Categoria.Model.Categoria cat){
            try{
                if(cat != null){
                    if (nomeIsbn.Equals(""))
                    {
                        return this.ctx.livros.Include("Categoria").Include("Editora").Include("Autor")
                     .Where(l => l.categoria.id == cat.id).ToList();
                    }
                    else
                    {
                        return this.ctx.livros.Include("Categoria").Include("Editora").Include("Autor")
                        .Where(l => (l.nome.Contains(nomeIsbn) || l.isbn.Contains(nomeIsbn)) && l.categoria.id == cat.id).ToList();
                    }
                }else{
                    return this.ctx.livros.Include("Categoria").Include("Editora").Include("Autor")
                    .Where(l => (l.nome.Contains(nomeIsbn) || l.isbn.Contains(nomeIsbn))).ToList();
                }
            }catch{
                return null;
            }

        }
        public List<Livro> getAllWithDep()
        {
            try
            {
                return this.ctx.livros.Include("Categoria").Include("Editora").Include("Autor").ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
