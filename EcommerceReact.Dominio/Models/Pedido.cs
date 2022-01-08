using System;
using System.Collections.Generic;

namespace EcommerceReact.Dominio.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string Endereco { get; set; }
        public int IdEncomenda { get; set; }
        public Encomenda Encomenda { get; set; }
        public List<Produto> PedidoProdutos { get; set; }
    }
}
