using Dapper;
using EcommerceReact.Dominio.Interfaces.Infra;
using EcommerceReact.Dominio.Interfaces.RepositorioLeitura;
using EcommerceReact.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceReact.Repositorio.Leitura
{
    public class PedidoRepositorioLeitura : IPedidoRepositorioLeitura
    {
        private readonly IConnectionHandler connection;
        public PedidoRepositorioLeitura(IConnectionHandler connection) => this.connection = connection;

        public async Task<IEnumerable<Pedido>> ObterPedidos(int paginacao, int pagina)
        {
            using (var conexao = connection.Create())
            {
                var listaPedidos = await conexao.QueryAsync<Pedido>(@$"
                            SELECT  pedido.id,
                                    pedido.datacriacao,
                                    pedido.dataentrega,
                                    pedido.endereco,
                                    pedido.idencomenda
                            FROM pedido
                            ORDER BY pedido.datacriacao
                            LIMIT {paginacao}
                            OFFSET {paginacao * pagina}");

                if (listaPedidos.Any())
                {
                    foreach (var pedido in listaPedidos)
                    {
                        pedido.Encomenda = await conexao.QueryFirstOrDefaultAsync<Encomenda>(@$"
                            SELECT  encomenda.id,
                                    encomenda.idequipe
                            FROM encomenda
                            WHERE encomenda.id = {pedido.IdEncomenda}");

                        if (pedido.Encomenda != null)
                        {
                            pedido.Encomenda.Equipe = await conexao.QueryFirstOrDefaultAsync<Equipe>(@$"
                                SELECT  equipe.id,
                                        equipe.nome,
                                        equipe.descricao,
                                        equipe.placaveiculo
                                FROM equipe
                                WHERE equipe.id = {pedido.Encomenda.IdEquipe}");
                        }

                        pedido.PedidoProdutos = (await conexao.QueryAsync<Produto>(@$"
                                SELECT  produto.id,
                                        produto.nome,
                                        produto.descricao,
                                        produto.valor
                                FROM pedidoproduto
                                LEFT JOIN produto ON produto.id = pedidoproduto.idproduto
                                WHERE pedidoproduto.id = {pedido.Id}")).ToList();
                    }
                }

                return listaPedidos;
            }
        }
    }
}
