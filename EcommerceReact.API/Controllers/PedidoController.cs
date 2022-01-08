using EcommerceReact.Dominio.Commands;
using EcommerceReact.Dominio.Interfaces.Handler;
using EcommerceReact.Dominio.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceReact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoCommandHandler _pedidoCommandHandler;
        public PedidoController(IPedidoCommandHandler pedidoCommandHandler) => this._pedidoCommandHandler = pedidoCommandHandler;

        /// <summary>
        /// Procura por todos os pedidos registrados
        /// </summary>
        /// <param name="parametros">Informe os dados de paginação para retornar os pedidos</param>
        /// <response code="200">Retorna a lista de pedidos registrados</response>
        /// <response code="204">Se não houver pedidos registrados</response>   
        /// <response code="400">Caso ocorra erro retorna a mensagem de exceção</response> 
        [HttpPost("ObterPedidos")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Pedido>>> ObterProdutos([FromBody] PedidoCommand parametros)
        {
            try
            {
                var pedidos = await _pedidoCommandHandler.ObterPedidos(parametros.Paginacao, parametros.Pagina);

                if (!pedidos.Any())
                    return NoContent();

                return Ok(pedidos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
