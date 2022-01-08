using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceReact.Dominio.Models
{
    public class Encomenda
    {
        public int Id { get; set; }
        public int IdEquipe { get; set; }
        public Equipe Equipe { get; set; }
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
    }
}
