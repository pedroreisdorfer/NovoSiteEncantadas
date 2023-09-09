using System.Data.SqlClient;
using WebEncantadas.Data;

namespace WebEncantadas
{
    public class ConnectionManager : IConnectionManager
    {
        private static string stringDeConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DB_Encantadas_teste;Data Source=LAPTOP-8RL84DG9\SQLEXPRESS";
        // aqui posso fazer de outra forma, passando nome da minha string de con~exão implementada em appsettings.json
        // private static string _connectionName = "NOME QUE DEFINE DA MINHA STIRNG DE CONEXÃO, QUE ATUALMENTE TEM UMA SOMENTE CHAMADA JUSTAMENTE: DefaultConnection, MAS QUE POSSO MUDAR"
        public static SqlConnection connection = null;

        public ConnectionManager()
        {
            connection = new SqlConnection(stringDeConexao);
        }

        public SqlConnection GetConnection() {

            //var cnnString = new SqlConnection(stringDeConexao);
            //return cnnString;
            return connection;
        } 
    }
}
