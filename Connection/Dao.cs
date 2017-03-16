using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

/*
 * @Author Jean Souza - Analise e Desenvolvimento Sistemas - Hauer 
 * Classe generica utilizada com o padrão Dao (Data Access Object)
 * Fornece uma cada de abstração para os metodos basicos evitando repetições de codigo nas classes filhas
 * Seguindo as caracteristcas da POO e modelo em camadas.
*/
namespace Biblioteca.Connection
{
    class Dao<T>
    {
        protected Context ctx = ContextManager.Instance.Context;

        public bool add(T obj)
        {
            try
            {
                ctx.Set(obj.GetType()).Add(obj);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void saveChanges()
        {
            ctx.SaveChanges();
        }
        public object getById(int id)
        {
            try
            {
                return ctx.Set(typeof(T)).Find(id);
            }catch(Exception e){
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public List<T> getAll()
        {
            try
            {
                Task<List<Object>> x = ctx.Set(typeof(T)).ToListAsync();
                
                //Da um cast para a lista do tipo do objeto
                return x.Result.Cast<T>().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public void update(Object obj)
        {
            try
            {
                ctx.Entry(obj).State = EntityState.Modified;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
        }
        public void delete(T obj)
        {
            try
            {
                ctx.Set(typeof(T)).Remove(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
