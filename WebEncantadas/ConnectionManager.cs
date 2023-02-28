using System.Data.SqlClient;

namespace WebEncantadas
{
    public class ConnectionManager
    {
        private static string stringDeConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DB_Encantadas_teste;Data Source=LAPTOP-8RL84DG9\SQLEXPRESS";


        public static SqlConnection GetConnection() {
        
            var cnnString = new SqlConnection(stringDeConexao);
            return cnnString;
        } 
    }
}
