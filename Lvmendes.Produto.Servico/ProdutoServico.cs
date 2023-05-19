
using Lvmendes.Produtos.Entidade;
using Lvmendes.Produtos.Repositorio.Interfaces;
using Lvmendes.Produtos.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Produtos.Servico
{
    //public class ProdutosServico : ComumServico<ProdutoEntidade>, IProdutosServico
    //{
    //    protected ProdutosServico(IComumRepositorio<ProdutoEntidade> repositorio) : base(repositorio)
    //    {
    //    }
    //}
    public class ProdutosServico : IProdutosServico
    {

        private IProdutoRepositorio ProdutoRepositorio;
        public ProdutosServico(IProdutoRepositorio _ProdutoRepositorio)
        {
            ProdutoRepositorio = _ProdutoRepositorio;
        }
        public string Adicionar(ProdutoEntidade entity)
        {
            return ProdutoRepositorio.Adicionar(entity);
        }

        public string Atualizar(ProdutoEntidade entity)
        {
            return ProdutoRepositorio.Atualizar(entity);
        }

        public string Deletar(Func<ProdutoEntidade, bool> predicate)
        {
            return ProdutoRepositorio.Deletar(predicate);
        }

        public List<ProdutoEntidade> ObterFiltros(Expression<Func<ProdutoEntidade, bool>> predicate)
        {
            return ProdutoRepositorio.ObterFiltros(predicate);
        }

        public List<ProdutoEntidade> ObterTodos(bool includes)
        {
            return ProdutoRepositorio.ObterTodos(includes);
        }

        public ProdutoEntidade Primeiro(Expression<Func<ProdutoEntidade, bool>> predicate)
        {
            return ProdutoRepositorio.Primeiro(predicate);
        }

        public ProdutoEntidade Procurar(params object[] key)
        {
            return ProdutoRepositorio.Procurar(key);
        }
    }
}
