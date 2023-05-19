using Lvmendes.Produtos.Entidade;
using Lvmendes.Produtos.Servico;
using Lvmendes.Produtos.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lvmendes.Produtos.ApiProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutosServico servico;

        public ProdutoController(IProdutosServico _servico)
        {
            servico = _servico;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<RetornoApi> Salvar(ProdutoEntidade item)
        {
            servico.Adicionar(item);
            return new RetornoApi
            {
                Resultado = true,
                Status = true
            };
        }


        /// <summary>
        /// Lista os itens da To-do list.
        /// </summary>
        /// <returns>Os itens da To-do list</returns>
        /// <response code="200">Returna os itens da To-do list cadastrados</response>
        [HttpGet]
        public ActionResult<RetornoApi> ObterProdutoEntidade(bool todos )
        {
            var retornoChamado = servico.ObterTodos(todos);
            RetornoApi retorno = new RetornoApi
            {
                Resultado = retornoChamado,
                Status = retornoChamado != null,
                Mensagem = retornoChamado == null ? "Produtos não Encontrado" : string.Empty

            };
            return retorno;
        }
    }
}
