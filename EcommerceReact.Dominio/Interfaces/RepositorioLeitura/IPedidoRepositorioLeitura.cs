using EcommerceReact.Dominio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceReact.Dominio.Interfaces.RepositorioLeitura
{
    public interface IPedidoRepositorioLeitura
    {
        Task<IEnumerable<Pedido>> ObterPedidos(int paginacao);
    }
}
