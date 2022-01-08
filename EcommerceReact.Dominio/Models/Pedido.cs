using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceReact.Dominio.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCricao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Endereco { get; set; }
    }
}
