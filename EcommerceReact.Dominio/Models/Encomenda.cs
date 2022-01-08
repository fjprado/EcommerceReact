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
