using Lvmendes.Produtos.Entidade;
using Lvmendes.Produtos.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Produtos.Repositorio
{
    //public class ProdutoRepositorio : ComumRepositorio<ProdutoEntidade>, IProdutoRepositorio
    //{       
    //    protected ProdutoRepositorio(ProdutoContext context) : base(context)
    //    {
    //    }
    //}

    public class ProdutoRepositorio : IProdutoRepositorio
    {
        internal ProdutoContext Context;
        public ProdutoRepositorio(ProdutoContext context)
        {
            Context = context;
        }
        public string Adicionar(ProdutoEntidade entity)
        {

            try
            {
                Context.Set<ProdutoEntidade>().Add(entity);
                Context.SaveChanges();
                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string Atualizar(ProdutoEntidade entity)
        {
            try
            {
                Context.Entry(entity).State = EntityState.Modified;
                Context.SaveChanges();
                return "Atualizar com sucesso!!";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string Deletar(Func<ProdutoEntidade, bool> predicate)
        {
            try
            {
                Context.Set<ProdutoEntidade>()
          .Where(predicate).ToList()
          .ForEach(del => Context.Set<ProdutoEntidade>().Remove(del));
                Context.SaveChanges();
                return "Deletado com sucesso!!";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public List<ProdutoEntidade> ObterFiltros(Expression<Func<ProdutoEntidade, bool>> predicate)
        {
            return Context.Set<ProdutoEntidade>().Where(predicate).ToList();
        }

        public List<ProdutoEntidade> ObterTodos(bool includes = false)
        {
            var query = Context.Set<ProdutoEntidade>().AsQueryable();
            
            return query.ToList();
        }

        public ProdutoEntidade Primeiro(Expression<Func<ProdutoEntidade, bool>> predicate)
        {
            return Context.Set<ProdutoEntidade>().Where(predicate).FirstOrDefault();
        }

        public ProdutoEntidade Procurar(params object[] key)
        {
            return Context.Set<ProdutoEntidade>().Find(key);
        }
    }
}
