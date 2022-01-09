using EcommerceReact.Dominio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceReact.Dominio.Interfaces.Handler
{
    public interface IPedidoCommandHandler
    {
        Task<IEnumerable<Pedido>> ObterPedidos(int pagina);
    }
}
