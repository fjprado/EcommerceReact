using EcommerceReact.Dominio.Interfaces.Handler;
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
    public class AutenticacaoController : ControllerBase
    {
        private readonly IAutenticacaoCommandHandler _autenticacaoCommandHandler;
        public AutenticacaoController(IAutenticacaoCommandHandler autenticacaoCommandHandler) => this._autenticacaoCommandHandler = autenticacaoCommandHandler;

        /// <summary>
        /// Realiza autenticação
        /// </summary>
        /// <response code="200">Retorna o token</response>
        /// <response code="204">Se não houver token</response>   
        /// <response code="400">Caso ocorra erro retorna a mensagem de exceção</response> 
        [HttpPost("ObterAutenticacao")]
        public ActionResult<string> ObterAutenticacao()
        {
            try
            {
                var token = _autenticacaoCommandHandler.ObterAutenticacao();

                if (token == null)
                    return NotFound("Não existe token válido");

                return Ok(token);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
