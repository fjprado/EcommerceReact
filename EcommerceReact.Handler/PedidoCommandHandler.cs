using EcommerceReact.Dominio.Interfaces.Handler;
using EcommerceReact.Dominio.Interfaces.RepositorioLeitura;
using EcommerceReact.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceReact.Handler
{
    public class PedidoCommandHandler : IPedidoCommandHandler
    {
        private readonly IPedidoRepositorioLeitura _pedidoRepositorioLeitura;

        public PedidoCommandHandler(IPedidoRepositorioLeitura pedidoRepositorioLeitura) => this._pedidoRepositorioLeitura = pedidoRepositorioLeitura;

        public async Task<IEnumerable<Pedido>> ObterPedidos(int paginacao, int pagina)
        {
            try
            {
                return await _pedidoRepositorioLeitura.ObterPedidos(paginacao, pagina);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
