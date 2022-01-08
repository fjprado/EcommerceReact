using EcommerceReact.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceReact.Dominio.Interfaces.Handler
{
    public interface IPedidoCommandHandler
    {
        Task<IEnumerable<Pedido>> ObterPedidos(int paginacao);
    }
}
