using System;

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
