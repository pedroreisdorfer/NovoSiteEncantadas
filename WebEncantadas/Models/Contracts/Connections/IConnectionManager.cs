using System.Data.SqlClient;

namespace WebEncantadas.Data
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }
}
