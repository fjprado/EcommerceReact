using EcommerceReact.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceReact.Dominio.Interfaces.RepositorioLeitura
{
    public interface IPedidoRepositorioLeitura
    {
        Task<IEnumerable<Pedido>> ObterPedidos(int paginacao);
    }
}
