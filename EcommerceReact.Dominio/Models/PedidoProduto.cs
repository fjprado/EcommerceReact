namespace EcommerceReact.Dominio.Models
{
    public class PedidoProduto
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
    }
}
