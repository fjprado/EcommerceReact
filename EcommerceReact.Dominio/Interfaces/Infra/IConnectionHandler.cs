using Npgsql;

namespace EcommerceReact.Dominio.Interfaces.Infra
{
    public interface IConnectionHandler
    {
        NpgsqlConnection Create(string connectionString = null);
    }
}
