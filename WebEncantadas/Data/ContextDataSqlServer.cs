using System.Data.SqlClient;
using WebEncantadas.Models.Contracts.Contexts;

namespace WebEncantadas.Data
{
    public class ContextDataSqlServer : IContextData
    {
        private readonly SqlConnection _connection = null;

        public ContextDataSqlServer(IConnectionManager connectionManager)
        {
            _connection = connectionManager.GetConnection();
        }

    }
}
